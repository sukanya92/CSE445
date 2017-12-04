using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CarDealershipApp
{

    public delegate void PriceCutEvent(Int32 pr);
   
    /* Plant class is responsible for creating plant thread, changing the price as per pricing model and triggering pricecut event*/
    public class Plant
    {
        static Random priceRange = new Random();
        public static Thread plantThread;
        private static Int32 carPrice = 51000;
        private static Int32 counter = 0;
        public static event PriceCutEvent PriceCut;
        MultiCellBuffer buffer;

        /* Decodes the string and returns the order object */
        public Order Decoder(string orderString)
        { 
            string[] orderItems = orderString.Split('_');
            Order order = new Order();
            order.SetUnitPrice(Int32.Parse(orderItems[0]));
            order.SetnoOfCars(Int32.Parse(orderItems[1]));
            order.SetCardNumber(Int32.Parse(orderItems[2]));
            order.SetSenderId(orderItems[3]);
            return order;
        }
        /* Starts the main plant thread */
        public void PlantFunc()
        {
            buffer = new MultiCellBuffer();
            do
            {
                Thread.Sleep(500);
                Int32 p = PricingModel();
                Plant.PriceChanged(p);
                string temp = buffer.GetOneCell();
                if (temp != "")
                {
                    Order order = Decoder(temp);
                    OrderProcessing orderProcess = new OrderProcessing(order);
                    Thread orderInProcess = new Thread(new ThreadStart(orderProcess.CreateOrder));
                    orderInProcess.Start();
                    orderInProcess.Join();
                }
            }
            while (counter < 20);
            Console.WriteLine("20 Price cuts are over!!");
            plantThread.Abort(); 
            Thread.CurrentThread.Abort();   
        }
        /* This model returns the next price which stands with in a specified range*/
        public Int32 PricingModel()
        {
            //Console.WriteLine("Debug - Inside pricing model");
            return priceRange.Next(50000,500000);
        }
        /* Returns the current car price */
        public Int32 GetPrice()
        { 
            return carPrice;
        }
        /* This function triggers the price cut event by changing the price(if lower) */
        public static void PriceChanged(Int32 p)
        {
            if (p < carPrice)
            {
                if (PriceCut != null)
                {
                    Plant.carPrice = p;
                    Console.WriteLine("\nNew reduced car price after pricecut is :" + carPrice);
                    PriceCut(p);
                    counter++ ;
                }
            }
            else { Plant.carPrice = p;
                Console.WriteLine("New car price is :" + carPrice);
            } 
        }
    }

    /* Order processing class is responsible for creating thread for each order(order string) read from multicell buffer and fulfilling*/
    public class OrderProcessing
    {
        Int32 unitPrice;
        Int32 noOfCars;
        Int32 taxRate;
        Int32 locationCharge;
        Int32 cardnumber;
        Int32[] registCard = {1234,4321,9876,6789,1459};
       
        public OrderProcessing(Order order)
        {
            this.unitPrice = order.GetUnitPrice();
            this.noOfCars = order.GetNoOfcars();
            this.taxRate = 6;
            this.locationCharge = 33;
            this.cardnumber = order.GetCardNumber();
        }
        /* This method fulfills the order */
        public void CreateOrder()
        {
            //Console.WriteLine("Debug - Inside create order");
            Int32 taxableAmt = this.unitPrice * this.noOfCars;
            Int32 totalPrice = taxableAmt+((taxableAmt * this.taxRate) / 100) + this.locationCharge;
            Boolean isCardVerified = VerifyCardNumber(this.cardnumber);
            if (isCardVerified)
            {
                Console.WriteLine("\n");
                Console.WriteLine("***********ORDER PLACED***********");
                Console.WriteLine("NO OF CARS  :{0}", this.noOfCars);
                Console.WriteLine("UNIT PRICE  :{0}", this.unitPrice);
                Console.WriteLine("TOTAL PRICE :${0}", totalPrice);
                Console.WriteLine("CARD CHARGED:{0}", this.cardnumber);
                Console.WriteLine("***********************************");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Order cannot be placed !!! <Invalid credit card number>");
            }
        }
        /* This method verifies if the card number is from valid registered cards */
        private Boolean VerifyCardNumber(Int32 cardnumber)
        {
            Boolean isCardRegistered = false;
            foreach(Int32 cardNo in registCard)
            {
                if (cardnumber == cardNo)
                {
                    return true;
                }
            }
            return isCardRegistered;
        }
    }

    /* Dealer class is responsible for creating dealer thread, responding to the pricecut event*/
    public class Dealer
    {
        static string orderStr=""; 
        Int32[] wallet = {1234,4321,6789,9876};
        static Random carNeed = new Random();
        MultiCellBuffer buffer;
        /* Encodes the order and returns the String */
        public string Encoder(Order orderObject)
        {
            string orderString = "";
            Int32 unitPrice = orderObject.GetUnitPrice();
            Int32 noOfCars = orderObject.GetNoOfcars();
            Int32 cardNo = orderObject.GetCardNumber();
            string senderId = orderObject.GetSenderId();
            orderString += unitPrice+"_"+noOfCars+"_"+cardNo+"_"+senderId;
            return orderString;
        }
        
        /* Responsible for Dealer thread*/
        public void DealerFunc()
        {
            Plant plant = new Plant();
            while (Plant.plantThread.IsAlive)
            {
                Thread.Sleep(10000);
                Int32 p = plant.GetPrice();
            }
            if (!Plant.plantThread.IsAlive)
            {
                Thread.CurrentThread.Abort();
            }
        }

        /* Event handler which responsds to the call back function in Plant thread */
        public void CarOnSale(Int32 p)
        {
            Console.WriteLine("SALE!!! Store{0} cars are on sale: Checkout our new reduced price ${1} only", Thread.CurrentThread.Name, p);
            Int32 unitPrice = p;
            Int32 need = carNeed.Next(1, 7);
            Int32 cardNo = wallet[new Random().Next(4)];
            string senderId = Thread.CurrentThread.Name;
            Boolean isOrderTobePlaced = true;
            //This is the expected standard worth of the order placed.(2*120000) i.e worth of 2 cars @120000 price 
            Int32 stdTotalOrder = 240000;
            Int32 currentTotalOrder = unitPrice * need;
            isOrderTobePlaced = (currentTotalOrder > stdTotalOrder);
            if (isOrderTobePlaced) { 
            Order order = new Order();
            order.SetUnitPrice(unitPrice);
            order.SetnoOfCars(need);
            order.SetCardNumber(cardNo);
            order.SetSenderId(senderId);
            orderStr = Encoder(order);
            buffer = new MultiCellBuffer();
            buffer.SetOneCell(orderStr);
            }
            else
            {
                Console.WriteLine("The business model does not allow this sale order to be placed! Sorry for that !!!");
            }
        }
    }
    
    /* Represents any order when decoded from order string from multicell buffer */
    public class Order
    {
        private Int32 unitPrice;
        private Int32 amount;
        private Int32 cardNumber;
        private string senderId;

        public Int32 GetUnitPrice()
        {
            return this.unitPrice;
        }
        public void SetUnitPrice(Int32 value)
        {
            this.unitPrice = value;
        }
        public Int32 GetNoOfcars()
        {
            return this.amount;
        }
        public void SetnoOfCars(Int32 value)
        {
            this.amount = value;
        }
        public Int32 GetCardNumber()
        {
            return this.cardNumber;
        }
        public void SetCardNumber(Int32 value)
        {
            this.cardNumber = value;
        }
        public string GetSenderId()
        {
            return this.senderId;
        }
        public void SetSenderId(string value)
        {
            this.senderId = value;
        }
    }

    /* This class takes care of the multicell buffer. It is a 2 cell multicell buffer */
    public class MultiCellBuffer
    {
        
        public static Semaphore readSemaphore = new Semaphore(0, 2);
        public static Semaphore writeSemaphore = new Semaphore(2, 2);
        static internal string[] orderBuffer = {"-1","-1"};
        /* Reads the cell content which is an encoded string */
        public string GetOneCell()
        {
            
            string result=""; Boolean readable = false; Boolean read = false;

                //Locks the buffer
                //Monitor.Enter(orderBuffer);
                while (!readable) {
                readSemaphore.WaitOne(5000);
                if (!(orderBuffer[0] == "-1")) {
                    readable = true;
                    
                    result = orderBuffer[0];
                    orderBuffer[0] = "-1";
                    
                    read = true;
                    break;
                    } else if (!(orderBuffer[1] == "-1"))
                    {
                    readable = true;
                    
                    result = orderBuffer[1];
                    
                    orderBuffer[0] = "-1";
                    
                    read = true;
                        break;
                    }
                    else
                    {
                    break;
                    }
                }
                readable = false;
                if(read)
                writeSemaphore.Release();
            //Monitor.Exit(orderBuffer);
            return result;
        }

        /* Writes the encoded string in the available cell of multicell buffer */
        public  void SetOneCell(String value)
        {
            Boolean writable = false; Boolean wrote = false;
            
            //lock the object
            Monitor.Enter(orderBuffer);
            while (!writable)
            {
                writeSemaphore.WaitOne(5000);
                if (orderBuffer[0] == "-1")
                {
                    writable = true;
                    
                    orderBuffer[0] = value;
                    
                    wrote = true;
                    break;
                }
                else if (orderBuffer[1] == "-1")
                {
                    writable = true;
                    
                    orderBuffer[1] = value;
                    
                    wrote = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            writable = false;
            if (wrote)
            {
                readSemaphore.Release();
            }
             Monitor.Exit(orderBuffer);
        }

    }

    /* To the run the main thread */
    public class MyApplication
    {
        static void Main(string[] args)
        {
            Plant p = new Plant();
            Plant.plantThread = new Thread(new ThreadStart(p.PlantFunc));
            Plant.plantThread.Name = "THREAD_PLNT_" ;
            Plant.plantThread.Start();

            Dealer d = new Dealer();
            Plant.PriceCut += new PriceCutEvent(d.CarOnSale);
            Thread[] dealers = new Thread[5];
            for(int i = 0; i < 5; i++)
            {
                dealers[i] = new Thread(new ThreadStart(d.DealerFunc));
                dealers[i].Name ="THREAD_DLR_"+ (i + 1).ToString();
                dealers[i].Start();
                dealers[i].Join();
            }
            Console.WriteLine("*************Main Thread Completed*****************");
        }
    }

}



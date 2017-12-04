using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SukanyasBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            String url = this.txtURL.Text;
            this.webBrowser1.Navigate(url);

        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            QuoteWcfRef.ServiceClient quoteService = new QuoteWcfRef.ServiceClient();
            try
            {
                String quote = this.txtInputQuote.Text;
                String result = quoteService.getStockquote(quote);
                this.lblQuoteInfo.Text = result;
                
            }
            catch(Exception exception)
            {
                this.lblQuoteInfo.Text = exception.Message.ToString();
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            EncryptionWcfRef.ServiceClient encryptionService = new EncryptionWcfRef.ServiceClient();
            try
            {
                String inputQuote = this.txtInputEncrypt.Text;
                String encryptedMsg = encryptionService.Encrypt(inputQuote);
                this.lblEncryptedMsg.Text = encryptedMsg;

            }
            catch(Exception exception)
            {
                this.lblEncryptedMsg.Text = exception.Message.ToString();
            }

            try
            {
                String encryptedMsg = this.lblEncryptedMsg.Text;
                String decryptedMsg = encryptionService.Decrypt(encryptedMsg);
                this.lblDecryptedMsg.Text = decryptedMsg;

            }
            catch (Exception exception)
            {
                this.lblDecryptedMsg.Text = exception.Message.ToString();
            }

        }
    }
}

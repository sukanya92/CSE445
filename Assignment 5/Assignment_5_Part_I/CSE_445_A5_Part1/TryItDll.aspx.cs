using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DllEncrypt;

public partial class TryItDll : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnEncrypt_Click(object sender, EventArgs e)
    {
        try
        {
            string input = TextEncrypt.Text;
            string output = "";
            if (input != string.Empty)
            {
                output = Cryption.Encrypt(input);
            }
            else
            {
                output = "Please enter valid input string";
            }
            LabelEncryptedResult.Text = output;
        }
        catch(Exception ex)
        {
            LabelEncryptedResult.Text = ex.Message;
        }
        }
        

    protected void BtnDecrypt_Click(object sender, EventArgs e)
    {
        try
        {
            string input = TextDecrypt.Text;
            string output = "";
            if (input != string.Empty)
            {
                output = Cryption.Decrypt(input);
            }
            else
            {
                output = "Please enter valid input string";
            }
            LabelDecryptedResult.Text = output;
        }
        catch(Exception ex)
        {
            LabelDecryptedResult.Text = ex.Message;
        }

    }
}
/* Class: Email.cs
 *
 * @Author Sean Wilson, Rob Duff
 * 
 * Description: Sends supervisor an email with the details of an order.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WWOC_Desktop_App
{

    
    /*
     * Description: Creates and sends an email to a specified address, using information from the newly created order.
     * Req: OrderID, UserID, PODate, ShippingTime, ReasonForOrder, Terms, Subtotal, SalesTax, ShippingHandling, 
     *      Othercharges, TotalPrice, and Approved from order object.
     * Returns: Email sent to specified email address.
     */
    class Email
    {
        private string fromaddr = "wildcatwoc@gmail.com";
        private string toaddr { get; set; }
        private Order sendOrder { get; set; }
        public List<OrderLineItem> partsForOrder { get; set; }
        public int vendorID { get; set; }
        public string shippingTime { get; set; }
        public double subtotal { get; set; }
        public double salesTax { get; set; }
        public double shippingHandling { get; set; }
        public double totalPrice { get; set; }


        public Email(Order order)
        {
            sendOrder = order;
            
        }

        public string SendOrderEmails()
        {
            string emailTest = "";
            for(int i = 0; i < sendOrder.cart.Count; i++)
            {
                Vendor tempVendor = new Vendor(sendOrder.cart[i].vendorID);
                toaddr = tempVendor.vendorEmail;
                vendorID = tempVendor.vendorID;
                findParts();
                calculateFinal();

                Boolean test = SendEmail();
                if(test == false)
                {
                    emailTest = "email failed to send";
                    break;
                }
                else
                {
                    emailTest = "email(s) sent successfully";
                }

            }

            return emailTest;
        }

        private void findParts()
        {
            partsForOrder = new List<OrderLineItem>();
            for (int i = 0; i < sendOrder.cart.Count; i++)
            {
                if(sendOrder.cart[i].vendorID == vendorID)
                {
                    partsForOrder.Add(sendOrder.cart[i]);
                }
            }
        }

        private void calculateFinal()
        {
            OrderLineItem[] arrCart = partsForOrder.ToArray();
            for (int i = 0; i < arrCart.Length; i++)
            {
                subtotal += arrCart[i].qty * arrCart[i].unitPrice;
            }
            shippingHandling = subtotal * 0.05;
            salesTax = subtotal * 0.0868;
            totalPrice = subtotal + shippingHandling + salesTax;
        }

        private string itemsToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < partsForOrder.Count; i++)
            {
                sb.Append("Part ID: " + partsForOrder[i].partID + " - ");
                sb.Append("Item Description: " + partsForOrder[i].itemDesc + " - ");
                sb.Append("Quantity: " + partsForOrder[i].qty + "\n");
            }
            return sb.ToString();
        }

        private Boolean SendEmail()
        {
            calculateFinal();

            string approved;

            if (sendOrder.approved == true)
            {
                approved = "Yes";
            }
            else
            {
                approved = "No";
            }

            try
            {
                string items = itemsToString();
                string body = "An order request has been created.\n\n" +
                              "Order ID: " + sendOrder.orderID + "\n" +
                              "User ID: " + sendOrder.userID + "\n" +
                              "PO Date: " + sendOrder.poDate + "\n" +
                              "\n" + "Parts: \n" + items + "\n" +
                              "Shipping Time: " + sendOrder.shippingTime + "\n" +
                              "Terms: " + sendOrder.terms + "\n" +
                              "Subtotal: " + subtotal.ToString("C2") + "\n" +
                              "Sales Tax: " + salesTax.ToString("C2") + "\n" +
                              "Shipping & Handling: " + shippingHandling.ToString("C2") + "\n" +
                              "Total Price: " + totalPrice.ToString("C2") + "\n" +
                              "Approved: " + approved + "\n";

                //Reason For Order are all currently blank for all items. Should these
                //be removed from the email? - Yes, Removed. Other Charges also removed

                string password = "MIS6772020";

                MailMessage msg = new MailMessage();
                msg.Subject = "Order Request Submitted for order:" + sendOrder.orderID;
                msg.From = new MailAddress(fromaddr);
                msg.Body = body;
                msg.To.Add(new MailAddress(toaddr));
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential(fromaddr, password);
                smtp.Send(msg);
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}

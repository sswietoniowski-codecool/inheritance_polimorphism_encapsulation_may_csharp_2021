namespace csharp_oop_1_demo
{
    public class OrderItem
    {
        protected string productName;
        protected int quantity;
        protected decimal unitPrice;

        public OrderItem(string productName, int quantity, decimal unitPrice)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public virtual decimal GetValue()
        {
            return quantity * unitPrice;
        }

        public override string ToString()
        {
            return $"{productName}, price: {unitPrice}, {quantity} szt, value: {GetValue()} PLN";
        }
    }
}
namespace csharp_oop_1_demo
{
    public class OrderItemWithPackage : OrderItem
    {
        protected decimal packageUnitPrice;
        protected string packageName;

        public OrderItemWithPackage(string productName, int quantity, decimal unitPrice, string packageName, decimal packageUnitPrice) :
            base(productName, quantity, unitPrice)
        {
            this.packageUnitPrice = packageUnitPrice;
            this.packageName = packageName;
        }

        public override decimal GetValue()
        {
            return quantity * unitPrice + quantity * packageUnitPrice;
        }
        
        public override string ToString()
        {
            return $"{productName}, price: {unitPrice}, package: {packageName}, package price: {packageUnitPrice} PLN" +
                   $", {quantity} szt, value: {GetValue()} PLN";
        }
    }
}
using ChainOfResponsibilityDesignPattern.Example1;
using ChainOfResponsibilityDesignPattern.Example1.Handlers;

// Handler zincirini oluştur
var stockHandler = new StockValidationHandler();
var paymentHandler = new PaymentValidationHandler();
var discountHandler = new DiscountHandler();
var shippingHandler = new ShippingHandler();

// Zinciri bağla: Stock → Payment → Discount → Shipping
stockHandler.SetNext(paymentHandler)
            .SetNext(discountHandler)
            .SetNext(shippingHandler);

// Sipariş oluştur
var order = new OrderRequest
{
    OrderId = "ORD-001",
    CustomerName = "John Doe",
    ProductName = "Laptop",
    Quantity = 2,
    TotalAmount = 3000m,
    DiscountCode = "SUMMER20"
};

// Sipariş işleme zincirini başlat
stockHandler.Handle(order);

// Sonucu göster
order.DisplayStatus();

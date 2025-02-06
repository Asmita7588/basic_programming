using basicProgramming;
using basicProgramming.oopsProgramming;

internal class Program
{
    private static void Main(string[] args)
    {
        //Payment 
        Payment payment = new CreadiCardPayment();
        payment.ProcessPayment();

        CreadiCardPayment creadiCardPayment = new CreadiCardPayment();
        creadiCardPayment.ProcessPayment();

        CashPayment cashPayment = new CashPayment();
        cashPayment.ProcessPayment();

        Calculator calculator1 = new Calculator();
        calculator1.add(2, 4);
        calculator1.add(3, 5,5.5);

        //Movie Ticket Price
        MovieTicketPrice movieTicketPrice = new MovieTicketPrice();
        movieTicketPrice.CalculateTicketPrice();

        LoginSystem logInSystem = new LoginSystem();
        logInSystem.LogIn();

        MenuDrivenCalculator menuDrivenCalculator = new MenuDrivenCalculator();
        menuDrivenCalculator.Calculate();

        CalculateAirQualityIndex calculator = new CalculateAirQualityIndex();
        calculator.CalculateAQI();

        //Shape Heirarachy
        Circle circle = new Circle();
        circle.GetArea();

        Square square = new Square();
        square.GetArea();

        Shape shape = new Circle();  




    }
}
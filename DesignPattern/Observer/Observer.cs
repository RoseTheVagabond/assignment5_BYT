// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        public string UserName { get; set; } = userName;

        public void AddSubscriber(Subject sub) {
            sub.RegisterObserver(this);
        }

        public void RemoveSubscriber(Subject sub) {
            sub.RemoveObserver(this);
        }

        public void Update(string availability) {
            Console.WriteLine("Observer " + UserName + " notified of the updated availability = " + availability);
        }
    }
}

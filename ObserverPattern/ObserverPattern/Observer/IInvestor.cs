using ObserverPattern.Publisher;

namespace ObserverPattern.Observer
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
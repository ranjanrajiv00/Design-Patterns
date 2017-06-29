using EventDeligate.Publisher;

namespace EventDeligate.Observer
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
namespace Auctions.Data.Services;
using Auctions.Models;

public interface IListingsService
{
    IQueryable<Listing> GetAll();
    Task Add(Listing listing);
}

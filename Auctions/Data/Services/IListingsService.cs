namespace Auctions.Data.Services;
using Auctions.Models;

public interface IListingsService
{
    IQueryable<Listing> GetAll();
    Task Add(Listing listing);
    Task<Listing> GetById(int? id);
}

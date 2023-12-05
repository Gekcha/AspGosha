using Microsoft.EntityFrameworkCore;
using Shop.Data.interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Repository
{
    public class WatchRepository : IAllWatches
    {
        private readonly AppDBContent appDBContent;

        public WatchRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Watch> Watches => appDBContent.Watch.Include(c => c.Category);

        public IEnumerable<Watch> getFavWatches => appDBContent.Watch.Where(p => p.isFavourite).Include(c => c.Category);

        public Watch getObjectWatch(int watchId) => appDBContent.Watch.FirstOrDefault(p => p.id == watchId);
    }
}

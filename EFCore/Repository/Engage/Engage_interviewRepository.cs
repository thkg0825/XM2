using Domain.Entity.Engage;
using Domain.Repository.IEngage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository.Engage
{
    public class Engage_interviewRepository : IEngage_interviewRepository
    {
        private readonly MyDbContext myc;

        public Engage_interviewRepository(MyDbContext myc)
        {
            this.myc = myc;
        }
        public async Task<int> AddEIAsync(Engage_interview ei)
        {
            myc.engage_Interviews.Add(ei);
            return await myc.SaveChangesAsync();
        }

        public async Task<int> DelEIAsync(Engage_interview ei)
        {
            myc.engage_Interviews.Remove(ei);
            return await myc.SaveChangesAsync();
        }

        public List<Engage_interview> SeleteAllEI()
        {
            return myc.engage_Interviews.ToList();
        }

        public async Task<int> UpdEIAsync(Engage_interview ei)
        {
            myc.engage_Interviews.Update(ei);
            return await myc.SaveChangesAsync();
        }
    }
}

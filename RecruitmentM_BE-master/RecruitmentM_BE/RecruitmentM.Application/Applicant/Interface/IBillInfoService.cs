using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentM.Application
{
    public interface IBillInfoService
    {
        Task<BillInfoDto> GetBillInfo(int id);
        List<BillInfoDto> GetBillsInfo();
        Task CreateUpdate(BillInfoInput input);
       

        Task DeleteBillInfo(int id);
    }
}

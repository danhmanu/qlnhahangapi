using Microsoft.AspNetCore.Mvc;
using QuanLyNhaHangAPI.Data;
using QuanLyNhaHangAPI.Entity;
using QuanLyNhaHangAPI.Models;
using System;

namespace QuanLyNhaHangAPI.Controllers
{
    public class TransferSlipController : Controller
    {
        private readonly AppDbContext _context;
        public TransferSlipController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// lấy danh sách vật tư - thiết bị đang có tại khoa
        /// </summary>
        /// <param name="idmedexah"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/TransferSlip/GetTransferSlipL/{idmedexah}")]
        public async Task<IActionResult> GetTransferSlipL(int idmedexah)
        {
            try
            {
                List<TransferSlipReadModel> rs = new List<TransferSlipReadModel>();
                List<transfersliph> transfersliphs = _context.transfersliphs.Where(z=>z.idline == idmedexah && z.active == 1).ToList();
                if (transfersliphs != null && transfersliphs.Count > 0)
                {
                    List<catesharel> unit = _context.catesharels.Where(z => z.active == 1 && z.idh == 1 ).ToList();
                    rs = (from sliph in transfersliphs
                          join slipl in _context.transferslipls.Where(z => z.active == 1) on sliph.idline equals slipl.idh 
                          join item in _context.itemsuppliess.Where(z => z.active == 1) on slipl.iditem equals item.idline 
                          join un in unit on item.idunit equals un.idline
                          select new TransferSlipReadModel()
                          {
                              idline = slipl.idline,
                              idh = slipl.idh,
                              iditem = slipl.iditem,
                              nameitem = item.name,
                              codeitem = item.code,
                              qtytransfer = slipl.qtytransfer,
                              nameunit = un.name,
                              active = slipl.active,
                              timecr = slipl.timecr,
                              timeup = slipl.timeup
                          }).ToList();
                }
                return Ok(rs);

            }
            catch (Exception ex)
            {
                throw;
            }
        }    
    }
}

using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300043;

namespace tpmod10_103022300042.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaControllers : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Muhammad Endihan Alfatah Nasution", Nim = "103022300064" },
            new Mahasiswa { Nama = "Muhammad Ihsan Romdhon", Nim = "103022330150" },
            new Mahasiswa { Nama = "Mohammad Ilham Firdaus ", Nim = "103022300043" },
            new Mahasiswa { Nama = "Muthi'ah Az Zahra", Nim = "103022330117" },
            new Mahasiswa { Nama = "Triana Julianingsih", Nim = "103022300053" },
            new Mahasiswa { Nama = "Syahdan Mansiz Kurniawan", Nim = "103022300079" }
        };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
            {
                return NotFound();
            }
            return mahasiswaList[index];
        }

        [HttpPost]
        public ActionResult<List<Mahasiswa>> Post([FromBody] Mahasiswa mhs)
        {
            mahasiswaList.Add(mhs);
            return mahasiswaList;
        }
        [HttpDelete("{index}")]
        public ActionResult<List<Mahasiswa>> Delete(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
            {
                return NotFound();
            }
            mahasiswaList.RemoveAt(index);
            return mahasiswaList;
        }
    }
}
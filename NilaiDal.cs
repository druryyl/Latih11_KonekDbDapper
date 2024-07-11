using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih11_KonekDbDapper
{
    public class NilaiDal
    {
        private const string _connString = "Server=(local); Database=SekolahKu; Trusted_Connection=True;TrustServerCertificate=True";

        public IEnumerable<NilaiModel> ListData()
        {
            const string sql = @"
                SELECT
                    MahasiswaName, MatakuliahName, aa.Nilai
                FROM
                    Nilai aa
                    INNER JOIN Matakuliah bb ON aa.MatakuliahId = bb.MatakuliahId
                    INNER JOIN Mahasiswa cc ON aa.MahasiswaId = cc.MahasiswaId";

            using var conn = new SqlConnection(_connString);
            var listNilai = conn.Query<NilaiModel>(sql);
            return listNilai;
        }
    }
}

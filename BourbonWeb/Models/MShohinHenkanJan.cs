using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "���iJAN�R�[�h�ϊ��}�X�^")]
    public class MShohinHenkanJan
    {
        [Column("JAN")]
        [Display(Name = "JAN")]
        public string? Jan { get; set; }

        [Column("SHOHIN_CD_TAIKEI")]
        [Display(Name = "���i�R�[�h�̌n")]
        public string? ShohinCdTaikei { get; set; }

        [Column("KY_SHOHIN_CD")]
        [Display(Name = "KY_SHOHIN_CD")]
        public string? KyShohinCd { get; set; }

        [Column("BUMON_BUNRUI")]
        [Display(Name = "BUMON_BUNRUI")]
        public string? BumonBunrui { get; set; }

        [Column("EIGYO_BUNRUI")]
        [Display(Name = "EIGYO_BUNRUI")]
        public string? EigyoBunrui { get; set; }

        [Column("SOKENSU")]
        [Display(Name = "������")]
        public int? Sokensu { get; set; }

    }
}
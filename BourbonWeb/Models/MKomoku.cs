using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "項目マスタ")]
    public class MKomoku
    {
        [Column("ky_komoku_cd")]
        [Display(Name = "項目CD")]
        public string? KyKomokuCd { get; set; }

        [Column("ky_atai")]
        [Display(Name = "値")]
        public string? KyAtai { get; set; }

        [Column("hyoji_moji")]
        [Display(Name = "表示文字")]
        public string? HyojiMoji { get; set; }

        [Column("def")]
        [Display(Name = "定義")]
        public string? Def { get; set; }

        [Column("toroku_ymd")]
        [Display(Name = "登録年月日")]
        public string? TorokuYmd { get; set; }

        [Column("toroku_time")]
        [Display(Name = "登録時分")]
        public string? TorokuTime { get; set; }

        [Column("delete_flg")]
        [Display(Name = "削除フラグ")]
        public string? DeleteFlg { get; set; }

        [Column("haisin_flg")]
        [Display(Name = "配信フラグ")]
        public string? HaisinFlg { get; set; }

        [Column("haisinbi")]
        [Display(Name = "配信日")]
        public string? Haisinbi { get; set; }

    }
}
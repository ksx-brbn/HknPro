using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "経費配分情報")]
    public class TSkKeihiHaibun
    {
        [Column("SINSEI_NO")]
        [Display(Name = "申請番号")]
        public string? SinseiNo { get; set; }

        [Column("KEIHI_SHO_CD")]
        [Display(Name = "経費所CD")]
        public string? KeihiShoCd { get; set; }

        [Column("KEIHI_SHO_NM")]
        [Display(Name = "経費所")]
        public string? KeihiShoNm { get; set; }

        [Column("KEIHI_SHA_CD")]
        [Display(Name = "経費者CD")]
        public string? KeihiShaCd { get; set; }

        [Column("KEIHI_SHA_NM")]
        [Display(Name = "経費者")]
        public string? KeihiShaNm { get; set; }

        [Column("HAIBUN_LEVEL")]
        [Display(Name = "配分レベル")]
        public string? HaibunLevel { get; set; }

        [Column("JOKEN_KBN")]
        [Display(Name = "条件区分")]
        public string? JokenKbn { get; set; }

        [Column("JOKEN_KBN_NM")]
        [Display(Name = "条件区分名")]
        public string? JokenKbnNm { get; set; }

        [Column("HASU_CHOSEI_SHO_FLG")]
        [Display(Name = "端数調整所")]
        public bool? HasuChoseiShoFlg { get; set; }

        [Column("HAIBUN_JOKEN_HYOJI")]
        [Display(Name = "分配条件表示")]
        public decimal? HaibunJokenHyoji { get; set; }

        [Column("HAIBUN_JOKEN")]
        [Display(Name = "分配条件")]
        public decimal? HaibunJoken { get; set; }

        [Column("REMARKS")]
        [Display(Name = "備考")]
        public string? Remarks { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "登録者")]
        public string? CreatedId { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "登録日")]
        public DateTime? CreatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "更新者")]
        public string? UpdatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "更新日")]
        public DateTime? UpdatedAt { get; set; }

        [Column("DELETED_FLG")]
        [Display(Name = "削除フラグ")]
        public bool? DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "ロックバージョン")]
        public int? LockVersion { get; set; }
    }
}
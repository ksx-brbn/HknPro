using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "採番管理マスタ")]
    public class MSaiban
    {
        [Column("NO_KBN")]
        [Display(Name = "番号区分")]
        public string? NoKbn { get; set; }

        [Column("KAISI_NO")]
        [Display(Name = "開始番号")]
        public int? KaisiNo { get; set; }

        [Column("GENZAI_NO")]
        [Display(Name = "現在番号")]
        public int? GenzaiNo { get; set; }

        [Column("SAISHU_NO")]
        [Display(Name = "最終番号")]
        public int? SaishuNo { get; set; }

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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "販促企画担当マスタ")]
    public class MHansokuKikakuTanto
    {
        [Column("TANTO_SHO_CD")]
        [Display(Name = "作成担当所コード")]
        public string? TantoShoCd { get; set; }

        [Column("TANTO_KAISI_YM")]
        [Display(Name = "担当開始年月")]
        public string? TantoKaisiYm { get; set; }

        [Column("TANTO_SHURYO_YM")]
        [Display(Name = "担当終了年月")]
        public string? TantoShuryoYm { get; set; }

        [Column("TANTO_TOKUI_CD")]
        [Display(Name = "担当得意先コード")]
        public string? TantoTokuiCd { get; set; }

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
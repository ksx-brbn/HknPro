using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "費目経費分類マスタ")]
    public class MSwHimokuKeihiBunrui
    {
        [Column("SYSTEM_KBN")]
        [Display(Name = "システム区分")]
        public string? SystemKbn { get; set; }

        [Column("KAISHA_CD")]
        [Display(Name = "会社CD")]
        public string? KaishaCd { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "請求区分")]
        public string? SeikyuKbn { get; set; }

        [Column("DENPYO_KBN")]
        [Display(Name = "伝票区分")]
        public string? DenpyoKbn { get; set; }

        [Column("HANSOK_KBN")]
        [Display(Name = "販促区分")]
        public string? HansokKbn { get; set; }

        [Column("HANSOK_KBN_SHOSAI")]
        [Display(Name = "販促区分詳細")]
        public string? HansokKbnShosai { get; set; }

        [Column("HANSOK_KBN_KOBETU")]
        [Display(Name = "販促区分個別")]
        public string? HansokKbnKobetu { get; set; }

        [Column("TAISHO_KAISI_YMD")]
        [Display(Name = "対象開始年月")]
        public string? TaishoKaisiYmd { get; set; }

        [Column("TAISHO_SHURYO_YMD")]
        [Display(Name = "対象終了年月")]
        public string? TaishoShuryoYmd { get; set; }

        [Column("KEIHI_BUNRUI_CD")]
        [Display(Name = "経費分類CD")]
        public string? KeihiBunruiCd { get; set; }

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
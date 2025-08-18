using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "販促費申請受付情報")]
    public class THansokuSinseiUketuke
    {
        [Column("SINSEI_KAGAMI_NO")]
        [Display(Name = "申請鑑暗号")]
        public string? SinseiKagamiNo { get; set; }

        [Column("UKETUKE_NO")]
        [Display(Name = "受付番号")]
        public string? UketukeNo { get; set; }

        [Column("UKETUKE_NITIJI")]
        [Display(Name = "受付日時")]
        public DateTime? UketukeNitiji { get; set; }

        [Column("UKETUKE_SHOZOKU_CD")]
        [Display(Name = "受付所属コード")]
        public string? UketukeShozokuCd { get; set; }

        [Column("UKETUKE_SHOZOKU_NM")]
        [Display(Name = "受付所属名")]
        public string? UketukeShozokuNm { get; set; }

        [Column("UKETUKE_SHA_CD")]
        [Display(Name = "受付者コード")]
        public string? UketukeShaCd { get; set; }

        [Column("UKETUKE_SHA_NM")]
        [Display(Name = "受付者名")]
        public string? UketukeShaNm { get; set; }

        [Column("UKETUKE_KIGOU")]
        [Display(Name = "受付記号")]
        public string? UketukeKigou { get; set; }

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
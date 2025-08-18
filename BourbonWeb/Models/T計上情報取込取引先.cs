using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "計上情報取込取引先")]
    public class T計上情報取込取引先
    {
        [Column("取引先取込コード")]
        [Display(Name = "取引先取込コード")]
        public string? TorihikisakiTorikomiCd { get; set; }

        [Column("取引先取込種別")]
        [Display(Name = "取引先取込種別")]
        public string? TorihikisakiTorikomiShubetu { get; set; }

        [Column("請求区分取込種別")]
        [Display(Name = "請求区分取込種別")]
        public string? SeikyuKbnTorikomiShubetu { get; set; }

        [Column("伝票区分取込種別")]
        [Display(Name = "伝票区分取込種別")]
        public string? DenpyoKbnTorikomiShubetu { get; set; }

        [Column("対象開始日")]
        [Display(Name = "対象開始日")]
        public string? TaishoKaishiYmd { get; set; }

        [Column("対象終了日")]
        [Display(Name = "対象終了日")]
        public string? TaishoShuryoYmd { get; set; }

        [Column("取引先名")]
        [Display(Name = "取引先名")]
        public string? TorihikisakiNm { get; set; }

        [Column("取引先グループコード")]
        [Display(Name = "取引先グループコード")]
        public string? TorihikisakiGroupCd { get; set; }

        [Column("取引先グループ名")]
        [Display(Name = "取引先グループ名")]
        public string? TorihikisakiGroupNm { get; set; }

        [Column("取引先側店コード")]
        [Display(Name = "取引先側店コード")]
        public string? TorihikisakiGawaTenCd { get; set; }

        [Column("取引先側店名")]
        [Display(Name = "取引先側店名")]
        public string? TorihikisakiGawaTenNm { get; set; }

        [Column("取引先側物流コード")]
        [Display(Name = "取引先側物流コード")]
        public string? TorihikisakiGawaButsuryuCd { get; set; }

        [Column("取引先側物流名")]
        [Display(Name = "取引先側物流名")]
        public string? TorihikisakiGawaButsuryuNm { get; set; }

        [Column("備考")]
        [Display(Name = "備考")]
        public string? Remarks { get; set; }

        [Column("制御区分")]
        [Display(Name = "制御区分")]
        public string? SeigyoKbn { get; set; }

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
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "所属マスタ")]
    public class MShozoku
    {
        [Column("SYSTEM_KBN")]
        [Display(Name = "システム区分")]
        public string? SystemKbn { get; set; }

        [Column("KAISHA_CD")]
        [Display(Name = "会社CD")]
        public string? KaishaCd { get; set; }

        [Column("SHOZOKU_CD")]
        [Display(Name = "所属CD")]
        public string? ShozokuCd { get; set; }

        [Column("KY_KAISI_YMD")]
        [Display(Name = "開始年月日")]
        public string? KyKaisiYmd { get; set; }

        [Column("KY_SHURYO_YMD")]
        [Display(Name = "終了年月日")]
        public string? KyShuryoYmd { get; set; }

        [Column("SHOZOKU_KAISHA_NM")]
        [Display(Name = "所属会社名")]
        public string? ShozokuKaishaNm { get; set; }

        [Column("SHOZOKU_HONBU_NM")]
        [Display(Name = "所属本部名")]
        public string? ShozokuHonbuNm { get; set; }

        [Column("SHOZOKU_BUMON_NM1")]
        [Display(Name = "所属部門名1")]
        public string? ShozokuBumonNm1 { get; set; }

        [Column("SHOZOKU_BUMON_NM2")]
        [Display(Name = "所属部門名2")]
        public string? ShozokuBumonNm2 { get; set; }

        [Column("SHOZOKU_NM1")]
        [Display(Name = "所属名1")]
        public string? ShozokuNm1 { get; set; }

        [Column("SHOZOKU_NM2")]
        [Display(Name = "所属名2")]
        public string? ShozokuNm2 { get; set; }

        [Column("SHOZOKU_ORDER")]
        [Display(Name = "所属ソート順")]
        public short? ShozokuOrder { get; set; }

        [Column("SHOZOKU_HYOJI")]
        [Display(Name = "所属表示")]
        public bool? ShozokuHyoji { get; set; }

        [Column("KA_JIGYOSHO_CD")]
        [Display(Name = "会社事業所CD")]
        public string? KaJigyoushoCd { get; set; }

        [Column("KA_KBN1")]
        [Display(Name = "会社区分1")]
        public string? KaKbn1 { get; set; }

        [Column("KA_KBN2")]
        [Display(Name = "会社区分2")]
        public string? KaKbn2 { get; set; }

        [Column("KA_CD")]
        [Display(Name = "会社CD")]
        public string? KaCd { get; set; }

        [Column("KA_REMARKS")]
        [Display(Name = "備考")]
        public string? KaRemarks { get; set; }

        [Column("KOZA_SIKIBETU_CD")]
        [Display(Name = "口座識別CD")]
        public string? KozaSikibetuCd { get; set; }

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
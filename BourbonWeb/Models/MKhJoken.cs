using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "価格販促マスタ")]
    public class MKhJoken
    {
        [Column("KAKAKU_HANSOKU_NO")]
        [Display(Name = "価格販促番号")]
        public string? KakakuHansokuNo { get; set; }

        [Column("TAISHO_YM")]
        [Display(Name = "対象年月")]
        public string? TaishoYm { get; set; }

        [Column("TAISHO_KAISI_YMD")]
        [Display(Name = "対象開始日")]
        public string? TaishoKaisiYmd { get; set; }

        [Column("TAISHO_SHURYO_YMD")]
        [Display(Name = "対象終了日")]
        public string? TaishoShuryoYmd { get; set; }

        [Column("KAKAKU_HANSOKU_MAIN_NM")]
        [Display(Name = "価格販促主題")]
        public string? KakakuHansokuMainNm { get; set; }

        [Column("KAKAKU_HANSOKU_SUB_NM")]
        [Display(Name = "価格販促副題")]
        public string? KakakuHansokuSubNm { get; set; }

        [Column("KIKAKU_ORDER_NO")]
        [Display(Name = "表示順")]
        public int? KikakuOrderNo { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "請求区分")]
        public string? SeikyuKbn { get; set; }

        [Column("SEIKYU_KBN_NM")]
        [Display(Name = "請求区分名")]
        public string? SeikyuKbnNm { get; set; }

        [Column("SHUKKA_KEITAI")]
        [Display(Name = "出荷形態")]
        public string? ShukkaKeitai { get; set; }

        [Column("SHUKKA_KEITAI_NM")]
        [Display(Name = "出荷形態名")]
        public string? ShukkaKeitaiNm { get; set; }

        [Column("SINSEI_HOHO")]
        [Display(Name = "申請方法")]
        public string? SinseiHoho { get; set; }

        [Column("SINSEI_HOHO_NM")]
        [Display(Name = "申請方法名")]
        public string? SinseiHohoNm { get; set; }

        [Column("TEKIYO_AREA_KBN")]
        [Display(Name = "適用エリア区分")]
        public string? TekiyoAreaKbn { get; set; }

        [Column("TEKIYO_AREA_KBN_NM")]
        [Display(Name = "適用エリア名")]
        public string? TekiyoAreaKbnNm { get; set; }

        [Column("TEKIYO_AREA_SHOSAI_CD")]
        [Display(Name = "適用エリア詳細CD")]
        public string? TekiyoAreaShosaiCd { get; set; }

        [Column("TEKIYO_AREA_SHOSAI_NM")]
        [Display(Name = "適用エリア詳細名")]
        public string? TekiyoAreaShosaiNm { get; set; }

        [Column("TEKIYO_JOKEN_KBN")]
        [Display(Name = "適用条件区分")]
        public string? TekiyoJokenKbn { get; set; }

        [Column("TEKIYO_JOKEN_KBN_NM")]
        [Display(Name = "適用条件名")]
        public string? TekiyoJokenKbnNm { get; set; }

        [Column("KAKAKU_HANSOKU_COMMENT")]
        [Display(Name = "価格販促コメント")]
        public string? KakakuHansokuComment { get; set; }

        [Column("REMARKS")]
        [Display(Name = "備考")]
        public string? Remarks { get; set; }

        [Column("KOUKAI_KBN")]
        [Display(Name = "公開区分")]
        public string? KoukaiKbn { get; set; }

        [Column("KOUKAI_KBN_NM")]
        [Display(Name = "公開区分名")]
        public string? KoukaiKbnNm { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "登録日")]
        public DateTime? CreatedAt { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "登録者")]
        public string? CreatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "更新日")]
        public DateTime? UpdatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "更新者")]
        public string? UpdatedId { get; set; }

        [Column("DELETED_FLG")]
        [Display(Name = "削除フラグ")]
        public bool? DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "ロックバージョン")]
        public int? LockVersion { get; set; }

    }
}
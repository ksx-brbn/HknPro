using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "販促企画マスタ")]
    public class MHansokuKikaku
    {
        [Column("HANSOK_KIKAKU_CD")]
        [Display(Name = "販促企画CD")]
        public string? HansokKikakuCd { get; set; }

        [Column("HANSOK_KIKAKU_NM")]
        [Display(Name = "販促企画名")]
        public string? HansokKikakuNm { get; set; }

        [Column("SEIKYU_CHOAI_CD")]
        [Display(Name = "対象企業CD")]
        public string? SeikyuChoaiCd { get; set; }

        [Column("SEIKYU_CHOAI_NM")]
        [Display(Name = "対象企業名")]
        public string? SeikyuChoaiNm { get; set; }

        [Column("TAISHO_MISE_CD")]
        [Display(Name = "対象店CD")]
        public string? TaishoMiseCd { get; set; }

        [Column("TAISHO_MISE_NM")]
        [Display(Name = "対象店名")]
        public string? TaishoMiseNm { get; set; }

        [Column("TAISHO_YM")]
        [Display(Name = "対象年月")]
        public string? TaishoYm { get; set; }

        [Column("TAISHO_KAISI_YMD")]
        [Display(Name = "対象開始年月日")]
        public string? TaishoKaisiYmd { get; set; }

        [Column("TAISHO_SHURYO_YMD")]
        [Display(Name = "対象終了年月日")]
        public string? TaishoShuryoYmd { get; set; }

        [Column("TAISHO_MISE_OYA_CD")]
        [Display(Name = "対象店親CD")]
        public string? TaishoMiseOyaCd { get; set; }

        [Column("JOKEN_TEKIYO_KBN")]
        [Display(Name = "条件摘要区分")]
        public string? JokenTekiyoKbn { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "請求区分")]
        public string? SeikyuKbn { get; set; }

        [Column("SEIKYU_KBN_NM")]
        [Display(Name = "請求区分名")]
        public string? SeikyuKbnNm { get; set; }

        [Column("KYOSAN_JOKEN")]
        [Display(Name = "協賛条件")]
        public string? KyosanJoken { get; set; }

        [Column("KYOSAN_JOKEN_NM")]
        [Display(Name = "協賛条件名")]
        public string? KyosanJokenNm { get; set; }

        [Column("JOTAI_KBN")]
        [Display(Name = "状態区分")]
        public short? JotaiKbn { get; set; }

        [Column("SHUKKA_KEITAI")]
        [Display(Name = "出荷形態")]
        public string? ShukkaKeitai { get; set; }

        [Column("TANTO_BUMON_CD")]
        [Display(Name = "担当部門CD")]
        public string? TantoBumonCd { get; set; }

        [Column("TANTO_BUMON_NM")]
        [Display(Name = "担当部門名")]
        public string? TantoBumonNm { get; set; }

        [Column("TANTO_KA_NM")]
        [Display(Name = "担当課名")]
        public string? TantoKaNm { get; set; }

        [Column("TANTO_SHO_CD")]
        [Display(Name = "担当所CD")]
        public string? TantoShoCd { get; set; }

        [Column("TANTO_SHO_NM")]
        [Display(Name = "担当所名")]
        public string? TantoShoNm { get; set; }

        [Column("TANTO_SHA_CD")]
        [Display(Name = "担当者CD")]
        public string? TantoShaCd { get; set; }

        [Column("TANTO_SHA_NM")]
        [Display(Name = "担当者名")]
        public string? TantoShaNm { get; set; }

        [Column("MITUMORI_TEKIYO_JOKEN")]
        [Display(Name = "見積適用条件")]
        public string? MitumoriTekiyoJoken { get; set; }

        [Column("MITUMORI_NYURYOKU_HOHO")]
        [Display(Name = "見積入力方法")]
        public string? MitumoriNyuryokuHoho { get; set; }

        [Column("SHONIN_SHA_CD_1")]
        [Display(Name = "一次承認者CD")]
        public string? ShoninShaCd1 { get; set; }

        [Column("SHONIN_SHA_NM_1")]
        [Display(Name = "一次承認者名")]
        public string? ShoninShaNm1 { get; set; }

        [Column("SHONIN_YMD_1")]
        [Display(Name = "一次承認日")]
        public string? ShoninYmd1 { get; set; }

        [Column("SHONIN_HMS_1")]
        [Display(Name = "一次承認時間")]
        public string? ShoninHms1 { get; set; }

        [Column("SHONIN_SHA_CD_2")]
        [Display(Name = "二次承認者CD")]
        public string? ShoninShaCd2 { get; set; }

        [Column("SHONIN_SHA_NM_2")]
        [Display(Name = "二次承認者名")]
        public string? ShoninShaNm2 { get; set; }

        [Column("SHONIN_YMD_2")]
        [Display(Name = "二次承認日")]
        public string? ShoninYmd2 { get; set; }

        [Column("SHONIN_HMS_2")]
        [Display(Name = "二次承認時間")]
        public string? ShoninHms2 { get; set; }

        [Column("SHONIN_SHA_CD_3")]
        [Display(Name = "三次承認者CD")]
        public string? ShoninShaCd3 { get; set; }

        [Column("SHONIN_SHA_NM_3")]
        [Display(Name = "三次承認者名")]
        public string? ShoninShaNm3 { get; set; }

        [Column("SHONIN_YMD_3")]
        [Display(Name = "三次承認日")]
        public string? ShoninYmd3 { get; set; }

        [Column("SHONIN_HMS_3")]
        [Display(Name = "三次承認時間")]
        public string? ShoninHms3 { get; set; }

        [Column("LATEST_SHONIN_JOTAI")]
        [Display(Name = "直近承認状態")]
        public short? LatestShoninJotai { get; set; }

        [Column("LATEST_SHONIN_SHA_CD")]
        [Display(Name = "直近承認者CD")]
        public string? LatestShoninShaCd { get; set; }

        [Column("LATEST_SHONIN_SHA_NM")]
        [Display(Name = "直近承認者名")]
        public string? LatestShoninShaNm { get; set; }

        [Column("LATEST_SHONIN_YMD")]
        [Display(Name = "直近承認日")]
        public string? LatestShoninYmd { get; set; }

        [Column("LATEST_SHONIN_HMS")]
        [Display(Name = "直近承認時間")]
        public string? LatestShoninHms { get; set; }

        [Column("SHONIN_IRAI_TUTI_FLG")]
        [Display(Name = "承認依頼通知フラグ")]
        public string? ShoninIraiTutiFlg { get; set; }

        [Column("SHONIN_IRAI_TUTI_CNT")]
        [Display(Name = "承認依頼通知回数")]
        public short? ShoninIraiTutiCnt { get; set; }

        [Column("SHONIN_IRAI_TUTI_NITIJI")]
        [Display(Name = "承認依頼通知日時")]
        public string? ShoninIraiTutiNitiji { get; set; }

        [Column("PRINT_CNT")]
        [Display(Name = "印刷回数")]
        public int? PrintCnt { get; set; }

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

        [Column("CD_KBN")]
        [Display(Name = "CD区分")]
        public string? CdKbn { get; set; }

        [Column("URI_KBN")]
        [Display(Name = "売区分")]
        public string? UriKbn { get; set; }

        [Column("TEISYUTU_SAKI")]
        [Display(Name = "提出先")]
        public string? TeisyutuSaki { get; set; }

        [Column("NEBIKI_SYUBETU")]
        [Display(Name = "値引き種別")]
        public string? NebikiSyubetu { get; set; }

        [Column("MITUMORI_TEKIYO_KIKAN")]
        [Display(Name = "見積適用期間")]
        public string? MitumoriTekiyoKikan { get; set; }

        [Column("MITUMORI_KEIZOKU_FLG")]
        [Display(Name = "見積継続フラグ")]
        public string? MitumoriKeizokuFlg { get; set; }

        [Column("HANSOKU_KIKAKU_CD_BASE")]
        [Display(Name = "販促企画CD元")]
        public string? HansokuKikakuCdBase { get; set; }
    }
}
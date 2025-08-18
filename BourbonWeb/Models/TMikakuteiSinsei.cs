using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "販促費支払未確定申請情報")]
    public class TMikakuteiSinsei
    {
        [Column("KAISHA_CD")]
        [Display(Name = "会社CD")]
        public string? KaishaCd { get; set; }

        [Column("URIKAKE_BUNRUI")]
        [Display(Name = "売掛分類")]
        public string? UrikakeBunrui { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "請求区分")]
        public string? SeikyuKbn { get; set; }

        [Column("SINSEI_NO")]
        [Display(Name = "申請番号")]
        public string? SinseiNo { get; set; }

        [Column("SINSEI_TAISHO_YM")]
        [Display(Name = "申請対象年月")]
        public string? SinseiTaishoYm { get; set; }

        [Column("SINSEI_KEIJO_YM")]
        [Display(Name = "申請計上年月")]
        public string? SinseiKeijoYm { get; set; }

        [Column("SIHARAI_YOTEI_YMD")]
        [Display(Name = "支払予定年月日")]
        public string? SiharaiYoteiYmd { get; set; }

        [Column("KEIHI_SHO_CD")]
        [Display(Name = "経費所CD")]
        public string? KeihiShoCd { get; set; }

        [Column("KEIHI_SHO_NM")]
        [Display(Name = "経費所名")]
        public string? KeihiShoNm { get; set; }

        [Column("KEIHI_SHA_CD")]
        [Display(Name = "経費者CD")]
        public string? KeihiShaCd { get; set; }

        [Column("KEIHI_SHA_NM")]
        [Display(Name = "経費者名")]
        public string? KeihiShaNm { get; set; }

        [Column("SINSEI_SHO_CD")]
        [Display(Name = "申請所CD")]
        public string? SinseiShoCd { get; set; }

        [Column("SINSEI_SHO_NM")]
        [Display(Name = "申請所名")]
        public string? SinseiShoNm { get; set; }

        [Column("SINSEI_SHA_CD")]
        [Display(Name = "申請者CD")]
        public string? SinseiShaCd { get; set; }

        [Column("SINSEI_SHA_NM")]
        [Display(Name = "申請者名")]
        public string? SinseiShaNm { get; set; }

        [Column("SINSEI_CHOAI_CD")]
        [Display(Name = "申請帳合CD")]
        public string? SinseiChoaiCd { get; set; }

        [Column("SINSEI_CHOAI_NM")]
        [Display(Name = "申請帳合名")]
        public string? SinseiChoaiNm { get; set; }

        [Column("SINSEI_CHOAI_BUNRUI_CD")]
        [Display(Name = "申請帳合分類CD")]
        public byte? SinseiChoaiBunruiCd { get; set; }

        [Column("SINSEI_SEIKYU_CD")]
        [Display(Name = "申請請求CD")]
        public string? SinseiSeikyuCd { get; set; }

        [Column("SINSEI_SEIKYU_NM")]
        [Display(Name = "申請請求名")]
        public string? SinseiSeikyuNm { get; set; }

        [Column("SINSEI_SEIKYU_BUNRUI_CD")]
        [Display(Name = "申請請求分類CD")]
        public byte? SinseiSeikyuBunruiCd { get; set; }

        [Column("SINSEI_SEIKYU_SIMEBI")]
        [Display(Name = "申請請求締日")]
        public string? SinseiSeikyuSimebi { get; set; }

        [Column("SINSEI_SEIKYU_SHUKIN_BI")]
        [Display(Name = "申請請求集金日")]
        public string? SinseiSeikyuShukinBi { get; set; }

        [Column("SINSEI_SEIKYU_KAISHU_SITE")]
        [Display(Name = "申請請求回収指定日")]
        public string? SinseiSeikyuKaishuSite { get; set; }

        [Column("SINSEI_SEIKYU_HONTEN_CD")]
        [Display(Name = "申請請求本店CD")]
        public string? SinseiSeikyuHontenCd { get; set; }

        [Column("SINSEI_SEIKYU_HONTEN_NM")]
        [Display(Name = "申請請求本店名")]
        public string? SinseiSeikyuHontenNm { get; set; }

        [Column("SINSEI_SEIKYU_HONTEN_BUNRUI_CD")]
        [Display(Name = "申請請求本店分類CD")]
        public byte? SinseiSeikyuHontenBunruiCd { get; set; }

        [Column("SINSEI_TOKUI_CD")]
        [Display(Name = "申請得意先CD")]
        public string? SinseiTokuiCd { get; set; }

        [Column("SINSEI_TOKUI_NM")]
        [Display(Name = "申請得意先名")]
        public string? SinseiTokuiNm { get; set; }

        [Column("SINSEI_TOKUI_KANA")]
        [Display(Name = "申請得意先名カナ")]
        public string? SinseiTokuiKana { get; set; }

        [Column("SINSEI_TOKUI_BUNRUI_CD")]
        [Display(Name = "申請得意先分類CD")]
        public byte? SinseiTokuiBunruiCd { get; set; }

        [Column("SINSEI_TOKUI_GYOTAI_KBN")]
        [Display(Name = "申請得意先業態区分")]
        public string? SinseiTokuiGyotaiKbn { get; set; }

        [Column("SIHARAI_KEITAI")]
        [Display(Name = "支払形態")]
        public string? SiharaiKeitai { get; set; }

        [Column("SIHARAI_SHUBETU")]
        [Display(Name = "支払種別")]
        public string? SiharaiShubetu { get; set; }

        [Column("KYOSAN_JOKEN_TANI_KBN")]
        [Display(Name = "協賛条件単位区分")]
        public string? KyosanJokenTaniKbn { get; set; }

        [Column("SINSEI_SEIKYU_NO")]
        [Display(Name = "申請請求書番号")]
        public string? SinseiSeikyuNo { get; set; }

        [Column("SINSEI_MITUMORI_NO")]
        [Display(Name = "申請見積書番号")]
        public string? SinseiMitumoriNo { get; set; }

        [Column("SINSEI_KEIYAKU_NO")]
        [Display(Name = "申請契約書番号")]
        public string? SinseiKeiyakuNo { get; set; }

        [Column("SINSEI_KYOSAN_GAKU")]
        [Display(Name = "申請協賛額")]
        public decimal? SinseiKyosanGaku { get; set; }

        [Column("MIBARAI_KANRI_SIME_YMD")]
        [Display(Name = "未払管理締年月日")]
        public string? MibaraiKanriSimeYmd { get; set; }

        [Column("MIBARAI_KANRI_SHORI_SIME_KBN")]
        [Display(Name = "未払管理処理締区分")]
        public string? MibaraiKanriShoriSimeKbn { get; set; }

        [Column("KEIYAKU_KEITAI")]
        [Display(Name = "契約形態")]
        public string? KeiyakuKeitai { get; set; }

        [Column("KEIYAKU_KIKAN")]
        [Display(Name = "契約期間")]
        public byte? KeiyakuKikan { get; set; }

        [Column("SINSEI_ASSOCIATION_CD")]
        [Display(Name = "申請紐づけCD")]
        public string? SinseiAssociationCd { get; set; }

        [Column("SINSEI_TOROKU_YMD")]
        [Display(Name = "申請登録年月日")]
        public string? SinseiTorokuYmd { get; set; }

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
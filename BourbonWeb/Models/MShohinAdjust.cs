using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "端数調整商品マスタ")]
    public class MShohinAdjust
    {
        [Column("KY_SHOHIN_CD")]
        [Display(Name = "商品CD")]
        public string? KyShohinCd { get; set; }

        [Column("KY_SUB_CD")]
        [Display(Name = "サブCD")]
        public string? KySubCd { get; set; }

        [Column("KY_KAISI_YMD")]
        [Display(Name = "開始年月日")]
        public string? KyKaisiYmd { get; set; }

        [Column("KY_SHURYO_YMD")]
        [Display(Name = "終了年月日")]
        public string? KyShuryoYmd { get; set; }

        [Column("NAME_KANA")]
        [Display(Name = "商品名カナ")]
        public string? NameKana { get; set; }

        [Column("RYAKUSHO_KANA")]
        [Display(Name = "略称カナ")]
        public string? RyakushoKana { get; set; }

        [Column("SHOHIN_NAME")]
        [Display(Name = "商品名")]
        public string? ShohinName { get; set; }

        [Column("RYAKUSHO_SYANAI")]
        [Display(Name = "社内略称")]
        public string? RyakushoSyanai { get; set; }

        [Column("SHOHIN_YOTO")]
        [Display(Name = "商品用途")]
        public string? ShohinYoto { get; set; }

        [Column("JAN")]
        [Display(Name = "JANCD")]
        public string? Jan { get; set; }

        [Column("ITF")]
        [Display(Name = "ITFCD")]
        public string? Itf { get; set; }

        [Column("OYA_HINSHU")]
        [Display(Name = "親品種")]
        public string? OyaHinshu { get; set; }

        [Column("OYA_TINRETU")]
        [Display(Name = "親陳列")]
        public string? OyaTinretu { get; set; }

        [Column("OYA_KIKAKU")]
        [Display(Name = "親企画")]
        public string? OyaKikaku { get; set; }

        [Column("OYA_YOBI")]
        [Display(Name = "親予備")]
        public string? OyaYobi { get; set; }

        [Column("DUMMY")]
        [Display(Name = "ダミー")]
        public string? Dummy { get; set; }

        [Column("SHOZOKU_BUNRUI")]
        [Display(Name = "所属分類")]
        public string? ShozokuBunrui { get; set; }

        [Column("EIGYO_BUNRUI")]
        [Display(Name = "営業分類")]
        public string? EigyoBunrui { get; set; }

        [Column("INSATU_JUN")]
        [Display(Name = "印刷順")]
        public decimal? InsatuJun { get; set; }

        [Column("BUMON_BUNRUI")]
        [Display(Name = "部門分類")]
        public string? BumonBunrui { get; set; }

        [Column("UTIWAKE_BUNRUI")]
        [Display(Name = "内訳分類")]
        public string? UtiwakeBunrui { get; set; }

        [Column("CATEGORY_BUNRUI1")]
        [Display(Name = "カテゴリー分類1")]
        public string? CategoryBunrui1 { get; set; }

        [Column("CATEGORY_BUNRUI2")]
        [Display(Name = "カテゴリー分類2")]
        public string? CategoryBunrui2 { get; set; }

        [Column("JICFS_BUNRUI")]
        [Display(Name = "JICFS分類")]
        public string? JicfsBunrui { get; set; }

        [Column("SHOHIN_GROUP")]
        [Display(Name = "商品グループ")]
        public string? ShohinGroup { get; set; }

        [Column("YOBI_BUNRUI1")]
        [Display(Name = "予備分類1")]
        public string? YobiBunrui1 { get; set; }

        [Column("OPP_KBN")]
        [Display(Name = "OPP区分")]
        public string? OppKbn { get; set; }

        [Column("KAKAKU_HYOJI")]
        [Display(Name = "価格表示")]
        public string? KakakuHyoji { get; set; }

        [Column("HYOJUN_KAKAKU")]
        [Display(Name = "表示価格")]
        public decimal? HyojunKakaku { get; set; }

        [Column("KIJUN_KAKAKU")]
        [Display(Name = "基準価格")]
        public decimal? KijunKakaku { get; set; }

        [Column("OROSI_KAKAKU")]
        [Display(Name = "卸価格")]
        public decimal? OroshiKakaku { get; set; }

        [Column("KAKERITU1")]
        [Display(Name = "掛け率1")]
        public decimal? Kakeritu1 { get; set; }

        [Column("KAKERITU2")]
        [Display(Name = "掛け率2")]
        public decimal? Kakeritu2 { get; set; }

        [Column("KAZEI_KBN")]
        [Display(Name = "課税区分")]
        public string? KazeiKbn { get; set; }

        [Column("SHOHIZEI_RITU")]
        [Display(Name = "消費税率")]
        public decimal? ShohizeiRitu { get; set; }

        [Column("HANSOKU_KBN")]
        [Display(Name = "販促区分")]
        public string? HansokuKbn { get; set; }

        [Column("KEIHIN_KBN")]
        [Display(Name = "景品区分")]
        public string? KeihinKbn { get; set; }

        [Column("R_TAISHO_KBN1")]
        [Display(Name = "対象区分1")]
        public string? RTaishoKbn1 { get; set; }

        [Column("R_TAISHO_KBN2")]
        [Display(Name = "対象区分2")]
        public string? RTaishoKbn2 { get; set; }

        [Column("SR_KBN")]
        [Display(Name = "SR区分")]
        public string? SrKbn { get; set; }

        [Column("YOBI")]
        [Display(Name = "予備分類1")]
        public string? Yobi { get; set; }

        [Column("RYO_HYOJI")]
        [Display(Name = "量表示")]
        public string? RyoHyoji { get; set; }

        [Column("RYO_TANI")]
        [Display(Name = "量単位")]
        public string? RyoTani { get; set; }

        [Column("CASE_RYO")]
        [Display(Name = "ケース量")]
        public decimal? CaseRyo { get; set; }

        [Column("BALL_RYO")]
        [Display(Name = "ボール量")]
        public decimal? BallRyo { get; set; }

        [Column("UTIWAKE_KBN")]
        [Display(Name = "内訳区分")]
        public string? UtiwakeKbn { get; set; }

        [Column("SHOHIN_KIKAKU")]
        [Display(Name = "商品価格")]
        public string? ShohinKikaku { get; set; }

        [Column("VAN_KIKAKU")]
        [Display(Name = "VAN規格")]
        public string? VanKikaku { get; set; }

        [Column("KIKAKU_TANI")]
        [Display(Name = "規格単位")]
        public string? KikakuTani { get; set; }

        [Column("HOSO_CASE")]
        [Display(Name = "包装ケース")]
        public string? HosoCase { get; set; }

        [Column("HOSO_PEASE")]
        [Display(Name = "包装ピース")]
        public string? HosoPease { get; set; }

        [Column("YOKI_CD")]
        [Display(Name = "容器CD")]
        public string? YokiCd { get; set; }

        [Column("YOKI_KBN")]
        [Display(Name = "容器区分")]
        public string? YokiKbn { get; set; }

        [Column("CASE_CHOHEN")]
        [Display(Name = "ケース長辺")]
        public decimal? CaseChoHen { get; set; }

        [Column("CASE_TANHEN")]
        [Display(Name = "ケース短辺")]
        public decimal? CaseTanHen { get; set; }

        [Column("CASE_TAKASA")]
        [Display(Name = "ケース高さ")]
        public decimal? CaseTakasa { get; set; }

        [Column("CASE_OMOSA")]
        [Display(Name = "ケース重さ")]
        public decimal? CaseOmosa { get; set; }

        [Column("CASE_YOSEKI")]
        [Display(Name = "ケース容積")]
        public decimal? CaseYoseki { get; set; }

        [Column("BALL_TYOHEN")]
        [Display(Name = "ボール長辺")]
        public decimal? BallTyohen { get; set; }

        [Column("BALL_TANHEN")]
        [Display(Name = "ボール短辺")]
        public decimal? BallTanhen { get; set; }

        [Column("BALL_TAKASA")]
        [Display(Name = "ボール高さ")]
        public decimal? BallTakasa { get; set; }

        [Column("BALL_OMOSA")]
        [Display(Name = "ボール重さ")]
        public decimal? BallOmosa { get; set; }

        [Column("BALL_YOSEKI")]
        [Display(Name = "ボール容積")]
        public decimal? BallYoseki { get; set; }

        [Column("PEASE_TYOHEN")]
        [Display(Name = "ピース長辺")]
        public decimal? PeaseTyohen { get; set; }

        [Column("PEASE_TANHEN")]
        [Display(Name = "ピース短辺")]
        public decimal? PeaseTanhen { get; set; }

        [Column("PEASE_TAKASA")]
        [Display(Name = "ピース高さ")]
        public decimal? PeaseTakasa { get; set; }

        [Column("PEASE_OMOSA")]
        [Display(Name = "ピース重さ")]
        public decimal? PeaseOmosa { get; set; }

        [Column("PEASE_YOSEKI")]
        [Display(Name = "ピース容積")]
        public decimal? PeaseYoseki { get; set; }

        [Column("PALLET")]
        [Display(Name = "パレット")]
        public string? Pallet { get; set; }

        [Column("MENSEKI")]
        [Display(Name = "面積")]
        public decimal? Menseki { get; set; }

        [Column("DANSU")]
        [Display(Name = "段数")]
        public decimal? Dansu { get; set; }

        [Column("SAITEI_LOT")]
        [Display(Name = "最低LOT")]
        public decimal? SaiteiLot { get; set; }

        [Column("YOBI_BUNRUI2")]
        [Display(Name = "予備分類2")]
        public string? YobiBunrui2 { get; set; }

        [Column("NEKASE_KIKAN")]
        [Display(Name = "寝かせ期間")]
        public string? NekaseKikan { get; set; }

        [Column("HIZUKE_HYOJIKBN")]
        [Display(Name = "日付表示区分")]
        public string? HizukeHyojikbn { get; set; }

        [Column("HIZUKE_INSATUKBN")]
        [Display(Name = "日付印刷区分")]
        public string? HizukeInsatukbn { get; set; }

        [Column("SHOMI_KBN")]
        [Display(Name = "賞味区分")]
        public string? ShomiKbn { get; set; }

        [Column("SHOMI_KIKAN")]
        [Display(Name = "賞味期間")]
        public decimal? ShomiKikan { get; set; }

        [Column("TEION_KBN")]
        [Display(Name = "低温区分")]
        public string? TeionKbn { get; set; }

        [Column("TUMI_SOKO1")]
        [Display(Name = "積倉庫1")]
        public string? TumiSoko1 { get; set; }

        [Column("TUMI_SOKO2")]
        [Display(Name = "積倉庫2")]
        public string? TumiSoko2 { get; set; }

        [Column("SEISAN_KYUSIBI")]
        [Display(Name = "生産休止日")]
        public string? SeisanKyusibi { get; set; }

        [Column("SEISAN_SAIKAIBI")]
        [Display(Name = "生産再開日")]
        public string? SeisanSaikaibi { get; set; }

        [Column("HANKEN_YUKO_YMD")]
        [Display(Name = "版権有効年月日")]
        public string? HankenYukoYmd { get; set; }

        [Column("SEISAN_TYUSIBI")]
        [Display(Name = "生産中止日")]
        public string? SeisanTyusibi { get; set; }

        [Column("TOROKU_YMD")]
        [Display(Name = "登録年月日")]
        public string? TorokuYmd { get; set; }

        [Column("TOROKU_TIME")]
        [Display(Name = "登録時分")]
        public string? TorokuTime { get; set; }

        [Column("DELETE_FLG")]
        [Display(Name = "削除フラグ")]
        public string? DeleteFlg { get; set; }

        [Column("HAISIN_FLG")]
        [Display(Name = "配信フラグ")]
        public string? HaisinFlg { get; set; }

        [Column("HAISIN_YMD")]
        [Display(Name = "配信年月日")]
        public string? HaisinYmd { get; set; }

        [Column("PALLET_GTIN")]
        [Display(Name = "パレットGTIN")]
        public string? PalletGtin { get; set; }

        [Column("PACK_GTIN")]
        [Display(Name = "パックGTIN")]
        public string? PackGtin { get; set; }

        [Column("CASE_GTIN")]
        [Display(Name = "ケースGTIN")]
        public string? CaseGtin { get; set; }

        [Column("BALL_GTIN")]
        [Display(Name = "ボールGTIN")]
        public string? BallGtin { get; set; }

        [Column("CASE_GTIN_RYO")]
        [Display(Name = "ケースGTIN量")]
        public decimal? CaseGtinRyo { get; set; }

        [Column("BALL_GTIN_RYO")]
        [Display(Name = "ボールGTIN量")]
        public decimal? BallGtinRyo { get; set; }

        [Column("GTIN_PACK_CASE")]
        [Display(Name = "GTINパックケース")]
        public decimal? GtinPackCase { get; set; }

        [Column("GTIN_PACK_MODE_K")]
        [Display(Name = "GTINパックモードK")]
        public string? GtinPackModeK { get; set; }

        [Column("GTIN_PACK_MODE_C")]
        [Display(Name = "GTINパックモードC")]
        public string? GtinPackModeC { get; set; }

        [Column("GTIN_PACK_MODE_B")]
        [Display(Name = "GTINパックモードB")]
        public string? GtinPackModeB { get; set; }

        [Column("GTIN_PACK_MODE_P")]
        [Display(Name = "GTINパックモードP")]
        public string? GtinPackModeP { get; set; }

        [Column("GTIN_UCHIBAKO_ID")]
        [Display(Name = "GTIN内箱ID")]
        public string? GtinUchibakoId { get; set; }

        [Column("JAN_CASE")]
        [Display(Name = "ケースJANCD")]
        public string? JanCase { get; set; }

        [Column("JAN_BALL")]
        [Display(Name = "ボールJANCD")]
        public string? JanBall { get; set; }

        [Column("HEAT_MAX")]
        [Display(Name = "最大温度")]
        public decimal? HeatMax { get; set; }

        [Column("HEAT_MIN")]
        [Display(Name = "最小温度")]
        public decimal? HeatMin { get; set; }

        [Column("HEAT_ID")]
        [Display(Name = "温度ID")]
        public string? HeatId { get; set; }

        [Column("BRAND_ID")]
        [Display(Name = "ブランドID")]
        public string? BrandId { get; set; }

        [Column("HANBAI_HONTEN")]
        [Display(Name = "販売本店")]
        public string? HanbaiHonten { get; set; }

        [Column("CHANNEL1")]
        [Display(Name = "チャンネル1")]
        public string? Channel1 { get; set; }

        [Column("CHANNEL2")]
        [Display(Name = "チャンネル2")]
        public string? Channel2 { get; set; }

        [Column("CHANNEL3")]
        [Display(Name = "チャンネル3")]
        public string? Channel3 { get; set; }

        [Column("FILELINK1")]
        [Display(Name = "ファイルリンク1")]
        public string? Filelink1 { get; set; }

        [Column("FILELINK2")]
        [Display(Name = "ファイルリンク2")]
        public string? Filelink2 { get; set; }

        [Column("FILELINK3")]
        [Display(Name = "ファイルリンク3")]
        public string? Filelink3 { get; set; }

        [Column("IMAGELINK")]
        [Display(Name = "イメージリンク")]
        public string? Imagelink { get; set; }

        [Column("NAME_ENGLISH")]
        [Display(Name = "商品名(英語)")]
        public string? NameEnglish { get; set; }

        [Column("CARE_ID")]
        [Display(Name = "ケアID")]
        public string? CareId { get; set; }

        [Column("GROUP_SHOHIN_CD")]
        [Display(Name = "グループ商品CD")]
        public string? GroupShohinCd { get; set; }

        [Column("GROUP_CATEGORY_CD")]
        [Display(Name = "グループカテゴリーCD")]
        public string? GroupCategoryCd { get; set; }

        [Column("GROUP_BUMON_CD")]
        [Display(Name = "グループ部門CD")]
        public string? GroupBumonCd { get; set; }

        [Column("ITTAI_SISAN_KBN")]
        [Display(Name = "一帯資産区分")]
        public string? IttaiSisanKbn { get; set; }

        [Column("SHOHIZEI_KBN")]
        [Display(Name = "消費税区分")]
        public string? ShohizeiKbn { get; set; }

        [Column("RICE_TRACEABILITY_KBN")]
        [Display(Name = "米トレーサビリティ区分")]
        public string? RiceTraceabilityKbn { get; set; }

        [Column("RICE_TRACEABILITY_TRN")]
        [Display(Name = "米トレーサビリティトラン")]
        public string? RiceTraceabilityTrn { get; set; }

        [Column("HATUBAIBI")]
        [Display(Name = "発売日")]
        public string? Hatubaibi { get; set; }

        [Column("KOURI_CD")]
        [Display(Name = "小売CD")]
        public string? KouriCd { get; set; }

        [Column("CATEGORY_BUNRUI1_NM")]
        [Display(Name = "カテゴリー分類1名称")]
        public string? CategoryBunrui1Nm { get; set; }

        [Column("CATEGORY_BUNRUI2_NM")]
        [Display(Name = "カテゴリー分類2名称")]
        public string? CategoryBunrui2Nm { get; set; }


    }
}
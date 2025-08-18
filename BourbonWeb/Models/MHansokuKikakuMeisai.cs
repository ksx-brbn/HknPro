using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "販促企画明細マスタ")]
    public class MHansokuKikakuMeisai
    {
        [Column("HANSOK_KIKAKU_CD")]
        [Display(Name = "販促企画コード")]
        public string? HansokKikakuCd { get; set; }

        [Column("HANSOK_KIKAKU_GYO_NO")]
        [Display(Name = "販促企画行番号")]
        public short? HansokKikakuGyoNo { get; set; }

        [Column("TOZAI_KBN")]
        [Display(Name = "東西区分")]
        public string? TozaiKbn { get; set; }

        [Column("HIMOKU_CD")]
        [Display(Name = "費目コード")]
        public string? HimokuCd { get; set; }

        [Column("HIMOKU_NM")]
        [Display(Name = "費目名")]
        public string? HimokuNm { get; set; }

        [Column("SAVE_FLG")]
        [Display(Name = "保存フラグ")]
        public string? SaveFlg { get; set; }

        [Column("MEISAI_CD_KBN")]
        [Display(Name = "明細コード区分")]
        public string? MeisaiCdKbn { get; set; }

        [Column("MEISAI_CD")]
        [Display(Name = "明細コード")]
        public string? MeisaiCd { get; set; }

        [Column("SHOHIN_NM")]
        [Display(Name = "商品名")]
        public string? ShohinNm { get; set; }

        [Column("EIGYO_BUNURI")]
        [Display(Name = "営業分類")]
        public string? EigyoBunuri { get; set; }

        [Column("CATEGORY_MEISAI")]
        [Display(Name = "カテゴリ明細")]
        public string? CategoryMeisai { get; set; }

        [Column("SR_KBN")]
        [Display(Name = "SR区分")]
        public string? SrKbn { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "請求区分")]
        public string? SeikyuKbn { get; set; }

        [Column("SHOHIN_SURYO")]
        [Display(Name = "商品数量")]
        public string? ShohinSuryo { get; set; }

        [Column("CASE_RYO")]
        [Display(Name = "ケース量")]
        public decimal? CaseRyo { get; set; }

        [Column("BALL_RYO")]
        [Display(Name = "ボール量")]
        public decimal? BallRyo { get; set; }

        [Column("TATENE")]
        [Display(Name = "建値")]
        public decimal? Tatene { get; set; }

        [Column("TANKA")]
        [Display(Name = "単価")]
        public decimal? Tanka { get; set; }

        [Column("KETTYAKU_TANKA")]
        [Display(Name = "決着単価")]
        public decimal? KettyakuTanka { get; set; }

        [Column("TATENE_NEBIKI_RITU")]
        [Display(Name = "建値値引率")]
        public decimal? TateneNebikiRitu { get; set; }

        [Column("TATENE_NEBIKI_RITU_WITHOUT_REBETE")]
        [Display(Name = "建値値引率_リベート抜き")]
        public decimal? TateneNebikiRituWithoutRebete { get; set; }

        [Column("TATENE_NEBIKI_GAKU")]
        [Display(Name = "建値値引額")]
        public decimal? TateneNebikiGaku { get; set; }

        [Column("TATENE_NEBIKI_GAKU_WITHOUT_REBETE")]
        [Display(Name = "建値値引額_リベート抜き")]
        public decimal? TateneNebikiGakuWithoutRebete { get; set; }

        [Column("KYOSAN_JOKEN")]
        [Display(Name = "協賛条件")]
        public decimal? KyosanJoken { get; set; }

        [Column("TONYA_HAKIDASI_RITU")]
        [Display(Name = "問屋吐出率")]
        public decimal? TonyaHakidasiRitu { get; set; }

        [Column("TONYA_HAKIDASI_GAKU")]
        [Display(Name = "問屋吐出額")]
        public decimal? TonyaHakidasiGaku { get; set; }

        [Column("GENBUTU_JOKEN_FLG")]
        [Display(Name = "現物条件フラグ")]
        public bool? GenbutuJokenFlg { get; set; }

        [Column("GENBUTU_JOKEN_URIAGE")]
        [Display(Name = "現物条件_売上")]
        public int? GenbutuJokenUriage { get; set; }

        [Column("GENBUTU_JOKEN_SERVICE")]
        [Display(Name = "現物条件_サービス")]
        public int? GenbutuJokenService { get; set; }

        [Column("SURYO_JOKEN_FLG")]
        [Display(Name = "数量条件フラグ")]
        public bool? SuryoJokenFlg { get; set; }

        [Column("SURYO_JOKEN_MIN")]
        [Display(Name = "数量条件最小")]
        public int? SuryoJokenMin { get; set; }

        [Column("SURYO_JOKEN_MAX")]
        [Display(Name = "数量条件最大")]
        public int? SuryoJokenMax { get; set; }

        [Column("MITUMORI_JOKEN_SIYO_FLG")]
        [Display(Name = "見積条件使用フラグ")]
        public bool? MitumoriJokenSiyoFlg { get; set; }

        [Column("HANSOK_HIMOKU_ORDER")]
        [Display(Name = "販促費目表示順")]
        public short? HansokHimokuOrder { get; set; }

        [Column("REMARKS")]
        [Display(Name = "備考")]
        public string? Remarks { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "登録者")]
        public string? CreatedId { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "作成日")]
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

        [Column("BAIKA")]
        [Display(Name = "売価")]
        public decimal? Baika { get; set; }

        [Column("BARA_SURYO")]
        [Display(Name = "バラ数量")]
        public decimal? BaraSuryo { get; set; }

        [Column("URIAGE_KOUJYO_HANTEI")]
        [Display(Name = "売上控除判定")]
        public string? UriageKoujyoHantei { get; set; }

        [Column("HANSOKU_NAIYOU")]
        [Display(Name = "販促内容")]
        public string? HansokuNaiyou { get; set; }

        [Column("JIZEN_SINSEI_HIMOKU_CD")]
        [Display(Name = "事前申請費目コード")]
        public string? JizenSinseiHimokuCd { get; set; }

        [Column("TAISHO_KINGAKU")]
        [Display(Name = "対象金額")]
        public decimal? TaishoKingaku { get; set; }

        [Column("KYOSAN_GAKU")]
        [Display(Name = "協賛額")]
        public decimal? KyosanGaku { get; set; }

        [Column("MEISAI_SUB_CD")]
        [Display(Name = "明細サブコード")]
        public string? MeisaiSubCd { get; set; }
    }
}
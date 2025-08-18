using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "販促費申請商品明細")]
    public class THansokuSinseiShohin
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

        [Column("SINSEI_GYO_NO")]
        [Display(Name = "申請行番号")]
        public short? SinseiGyoNo { get; set; }

        [Column("SINSEI_MEISAI_CD_KBN")]
        [Display(Name = "明細コード区分")]
        public string? SinseiMeisaiCdKbn { get; set; }

        [Column("SINSEI_SHOHIN_CD_KBN")]
        [Display(Name = "商品コード使用区分")]
        public string? SinseiShohinCdKbn { get; set; }

        [Column("EIGYO_BUNRUI")]
        [Display(Name = "営業分類")]
        public string? EigyoBunrui { get; set; }

        [Column("SINSEI_MEISAI_CD")]
        [Display(Name = "明細コード")]
        public string? SinseiMeisaiCd { get; set; }

        [Column("SINSEI_NAIYO")]
        [Display(Name = "申請内容")]
        public string? SinseiNaiyo { get; set; }

        [Column("JISHA_TAISHO_KINGAKU")]
        [Display(Name = "自社対象金額")]
        public decimal? JishaTaishoKingaku { get; set; }

        [Column("TATENE")]
        [Display(Name = "建値")]
        public decimal? Tatene { get; set; }

        [Column("TORIHIKI_TAISHO_KINGAKU")]
        [Display(Name = "取引先対象金額")]
        public decimal? TorihikiTaishoKingaku { get; set; }

        [Column("NOKA")]
        [Display(Name = "納価")]
        public decimal? Noka { get; set; }

        [Column("TONYA_HAKIDASI_REBATE_RITU")]
        [Display(Name = "問屋吐出リベート率")]
        public decimal? TonyaHakidasiRebateRitu { get; set; }

        [Column("TONYA_HAKIDASI_GAKU")]
        [Display(Name = "問屋吐出額(1個当)")]
        public decimal? TonyaHakidasiGaku { get; set; }

        [Column("TONYA_TAISHO_GAKU")]
        [Display(Name = "問屋対象額")]
        public decimal? TonyaTaishoGaku { get; set; }

        [Column("KYOSAN_JOKEN")]
        [Display(Name = "協賛条件")]
        public decimal? KyosanJoken { get; set; }

        [Column("KYOSAN_SURYO_A")]
        [Display(Name = "協賛数Ａ")]
        public int? KyosanSuryoA { get; set; }

        [Column("KYOSAN_SURYO_B")]
        [Display(Name = "協賛数Ｂ")]
        public int? KyosanSuryoB { get; set; }

        [Column("KYOSAN_SURYO_C")]
        [Display(Name = "協賛数Ｃ")]
        public int? KyosanSuryoC { get; set; }

        [Column("KYOSAN_SOBARASU")]
        [Display(Name = "協賛総バラ数")]
        public int? KyosanSobirasu { get; set; }

        [Column("KYOSAN_GAKU")]
        [Display(Name = "協賛額")]
        public decimal? KyosanGaku { get; set; }

        [Column("KYOSAN_GAKU_ZEI_KBN")]
        [Display(Name = "協賛額消費税区分")]
        public string? KyosanGakuZeiKbn { get; set; }

        [Column("KYOSAN_GAKU_ZEI_RITU")]
        [Display(Name = "協賛額消費税率")]
        public decimal? KyosanGakuZeiRitu { get; set; }

        [Column("KYOSAN_GAKU_ZEI_GAKU")]
        [Display(Name = "協賛額消費税額")]
        public decimal? KyosanGakuZeiGaku { get; set; }

        [Column("HIMOKU_KYOSAN_GAKU_CHOSEI")]
        [Display(Name = "費目別協賛額調整額")]
        public decimal? HimokuKyosanGakuChosei { get; set; }

        [Column("KYOSAN_NAIYO_COMMENT")]
        [Display(Name = "協賛内容コメント明細")]
        public string? KyosanNaiyoComment { get; set; }

        [Column("TORIKOMI_KBN")]
        [Display(Name = "取込区分")]
        public string? TorikomiKbn { get; set; }

        [Column("TORIHIKI_SHOHIN_CD_SIYO_KBN")]
        [Display(Name = "取引先商品コード使用区分")]
        public string? TorihikiShohinCdSiyoKbn { get; set; }

        [Column("TORIHIKI_SHOHIN_CD")]
        [Display(Name = "取引先商品コード")]
        public string? TorihikiShohinCd { get; set; }

        [Column("TORIHIKI_SENYO_SHOHIN_CD")]
        [Display(Name = "取引先専用商品コード")]
        public string? TorihikiSenyoShohinCd { get; set; }

        [Column("TORIHIKI_SITEI_TANKA")]
        [Display(Name = "取引先指定単価")]
        public decimal? TorihikiSiteiTanka { get; set; }

        [Column("TORIHIKI_JOKEN_KBN")]
        [Display(Name = "取引先条件区分")]
        public string? TorihikiJokenKbn { get; set; }

        [Column("TORIHIKI_JOKEN")]
        [Display(Name = "取引先条件")]
        public decimal? TorihikiJoken { get; set; }

        [Column("TORIHIKI_SEIKYU_TAISHO_TANI_KBN")]
        [Display(Name = "取引先請求対象数量／金額単位")]
        public string? TorihikiSeikyuTaishoTaniKbn { get; set; }

        [Column("TORIHIKI_SEIKYU_KEIJO_TAISHO_GAKU_SURYO")]
        [Display(Name = "取引先請求計上対象数量／金額")]
        public decimal? TorihikiSeikyuKeijoTaishoGakuSuryo { get; set; }

        [Column("TORIHIKI_MISHU_NO")]
        [Display(Name = "取引先未収番号")]
        public string? TorihikiMishuNo { get; set; }

        [Column("TORIHIKI_SEIKYU_SIME")]
        [Display(Name = "取引先請求締日")]
        public string? TorihikiSeikyuSime { get; set; }

        [Column("DENPYO_NITIJI")]
        [Display(Name = "伝票日時")]
        public string? DenpyoNitiji { get; set; }

        [Column("DENPYO_NO")]
        [Display(Name = "伝票番号")]
        public string? DenpyoNo { get; set; }

        [Column("DENPYO_GYO_NO")]
        [Display(Name = "伝票行番号")]
        public short? DenpyoGyoNo { get; set; }

        [Column("SEIKYU_CD")]
        [Display(Name = "請求先コード")]
        public string? SeikyuCd { get; set; }

        [Column("SEIKYU_GAITO_YMD")]
        [Display(Name = "請求該当日")]
        public string? SeikyuGaitoYmd { get; set; }

        [Column("DENPYO_YMD")]
        [Display(Name = "伝票年月日")]
        public string? DenpyoYmd { get; set; }

        [Column("TANTO_SHO")]
        [Display(Name = "担当所")]
        public string? TantoSho { get; set; }

        [Column("SAGAKU_REC_KBN")]
        [Display(Name = "差額レコード区分")]
        public string? SagakuRecKbn { get; set; }

        [Column("HANSOK_HIMOKU_CD")]
        [Display(Name = "販促費目コード")]
        public string? HansokHimokuCd { get; set; }

        [Column("MITUMORI_TEKIYO")]
        [Display(Name = "見積適用")]
        public string? MitumoriTekiyo { get; set; }

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

        [Column("MITUMORI_TEKIYO_NO")]
        [Display(Name = "見積適用番号")]
        public string? MitumoriTekiyoNo { get; set; }

        [Column("URIAGE_KOUJYO_HANTEI")]
        [Display(Name = "売上控除判定")]
        public string? UriageKoujyoHantei { get; set; }

        [Column("HANSOKU_NAIYOU")]
        [Display(Name = "販促内容")]
        public string? HansokuNaiyou { get; set; }

        [Column("ZEI_RITU_KBN")]
        [Display(Name = "税率区分")]
        public string? ZeiRituKbn { get; set; }

        [Column("ITTAI_SISAN_KBN")]
        [Display(Name = "一帯資産区分")]
        public string? IttaiSisanKbn { get; set; }

        [Column("KEIHI_BUNRUI")]
        [Display(Name = "経費分類")]
        public string? KeihiBunrui { get; set; }
    }
}
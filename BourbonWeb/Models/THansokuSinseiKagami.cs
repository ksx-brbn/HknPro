using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "販促費申請鑑情報")]
    public class THansokuSinseiKagami
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

        [Column("SINSEI_KAGAMI_NO")]
        [Display(Name = "申請鏡番号")]
        public string? SinseiKagamiNo { get; set; }

        [Column("KAIKEI_KEIJO_YM")]
        [Display(Name = "会計計上年月")]
        public string? KaikeiKeijoYm { get; set; }

        [Column("SINSEI_KAGAMI_DAIHYO_NO")]
        [Display(Name = "申請鑑代表番号")]
        public string? SinseiKagamiDaihyoNo { get; set; }

        [Column("SINSEI_KAGAMI_DAIHYO_CD")]
        [Display(Name = "申請鑑代表コード")]
        public string? SinseiKagamiDaihyoCd { get; set; }

        [Column("SINSEI_KAGAMI_DAIHYO_NM")]
        [Display(Name = "申請鑑代表店名")]
        public string? SinseiKagamiDaihyoNm { get; set; }

        [Column("SIHARAI_KEITAI")]
        [Display(Name = "支払形態")]
        public string? SiharaiKeitai { get; set; }

        [Column("SIHARAI_SHUBETU")]
        [Display(Name = "支払種別")]
        public string? SiharaiShubetu { get; set; }

        [Column("SIHARAI_YOTEI_YMD")]
        [Display(Name = "支払予定日")]
        public string? SiharaiYoteiYmd { get; set; }

        [Column("SIHARAI_KAKUTEI_YMD")]
        [Display(Name = "支払確定日")]
        public string? SiharaiKakuteiYmd { get; set; }

        [Column("SIHARAI_KAKUTEI_NO")]
        [Display(Name = "支払手続確定番号")]
        public string? SiharaiKakuteiNo { get; set; }

        [Column("SIHARAI_TETUZUKI_SHO_CD")]
        [Display(Name = "支払手続所コード")]
        public string? SiharaiTetuzukiShoCd { get; set; }

        [Column("SIHARAI_TETUZUKI_SHA_CD")]
        [Display(Name = "支払手続者コード")]
        public string? SiharaiTetuzukiShaCd { get; set; }

        [Column("SIHARAI_TETUZUKI_SHOZOKU_CD")]
        [Display(Name = "支払手続所属コード")]
        public string? SiharaiTetuzukiShozokuCd { get; set; }

        [Column("SIHARAI_TETUZUKI_SHOZOKU_NM")]
        [Display(Name = "支払手続所属名")]
        public string? SiharaiTetuzukiShozokuNm { get; set; }

        [Column("SIHARAI_TETUZUKI_YMD")]
        [Display(Name = "支払手続日")]
        public string? SiharaiTetuzukiYmd { get; set; }

        [Column("SIHARAI_TETUZUKI_TIME")]
        [Display(Name = "支払手続時間")]
        public string? SiharaiTetuzukiTime { get; set; }

        [Column("SHORI_YMD")]
        [Display(Name = "処理日")]
        public string? ShoriYmd { get; set; }

        [Column("SIWAKE_DENPYO_NO")]
        [Display(Name = "仕訳伝票入力番号")]
        public string? SiwakeDenpyoNo { get; set; }

        [Column("SIWAKE_DENPYO_SUB_NO")]
        [Display(Name = "仕訳伝票入力番号枝番")]
        public string? SiwakeDenpyoSubNo { get; set; }

        [Column("KYOSAN_COMMENT_HYOSI")]
        [Display(Name = "協賛内容コメント表紙")]
        public string? KyosanCommentHyosi { get; set; }

        [Column("JOTAI_KBN")]
        [Display(Name = "状態区分")]
        public string? JotaiKbn { get; set; }

        [Column("SINSEI_KAGAMI_SHO_CD")]
        [Display(Name = "鑑申請所コード")]
        public string? SinseiKagamiShoCd { get; set; }

        [Column("SINSEI_KAGAMI_SHO_NM")]
        [Display(Name = "鑑申請所名")]
        public string? SinseiKagamiShoNm { get; set; }

        [Column("SINSEI_KAGAMI_SHA_CD")]
        [Display(Name = "鑑申請者コード")]
        public string? SinseiKagamiShaCd { get; set; }

        [Column("SINSEI_KAGAMI_SHA_NM")]
        [Display(Name = "鑑申請者名")]
        public string? SinseiKagamiShaNm { get; set; }

        [Column("SINSEI_SHO_INSATU_YMD")]
        [Display(Name = "申請書印刷要求日")]
        public string? SinseiShoInsatuYmd { get; set; }

        [Column("SINSEI_SHO_INSATU_TIME")]
        [Display(Name = "申請書要求時間")]
        public string? SinseiShoInsatuTime { get; set; }

        [Column("SINSEI_SHO_INSATU_CNT")]
        [Display(Name = "申請書要求回数")]
        public short? SinseiShoInsatuCnt { get; set; }

        [Column("KYOSAN_GAKU")]
        [Display(Name = "協賛額")]
        public decimal? KyosanGaku { get; set; }

        [Column("ZEI_KEISAN_KBN")]
        [Display(Name = "消費税計算区分")]
        public string? ZeiKeisanKbn { get; set; }

        [Column("ZEI_HASU_SHORI_KBN")]
        [Display(Name = "消費税端数処理区分")]
        public string? ZeiHasuShoriKbn { get; set; }

        [Column("KYOSAN_GAKU_ZEI_GAKU")]
        [Display(Name = "協賛額消費税額")]
        public decimal? KyosanGakuZeiGaku { get; set; }

        [Column("KYOSAN_GAKU_ZEI_GAKU_CHOSEI")]
        [Display(Name = "協賛額消費税調整額")]
        public decimal? KyosanGakuZeiGakuChosei { get; set; }

        [Column("KYOSAN_GAKU_ZEI_NUKI")]
        [Display(Name = "協賛額税抜額")]
        public decimal? KyosanGakuZeiNuki { get; set; }

        [Column("DISPLAY_ORDER")]
        [Display(Name = "表示ソート順")]
        public short? DisplayOrder { get; set; }

        [Column("URIKAKE_NEBIKI_RENKEI")]
        [Display(Name = "売掛値引連携")]
        public string? UrikakeNebikiRenkei { get; set; }

        [Column("URIKAKE_SR_RENKEI")]
        [Display(Name = "売掛SR連携")]
        public string? UrikakeSrRenkei { get; set; }

        [Column("EIGYO_AREA_RENKEI")]
        [Display(Name = "営業エリア連携")]
        public string? EigyoAreaRenkei { get; set; }

        [Column("SONOTA_RENKEI")]
        [Display(Name = "その他連携")]
        public string? SonotaRenkei { get; set; }

        [Column("HONSHA_SHONIN_KAKUTEI_NO")]
        [Display(Name = "本社承認確定番号")]
        public string? HonshaShoninKakuteiNo { get; set; }

        [Column("HONSHA_SHONIN_SHO_CD")]
        [Display(Name = "本社承認担当所コード")]
        public string? HonshaShoninShoCd { get; set; }

        [Column("HONSHA_SHONIN_SHA_CD")]
        [Display(Name = "本社承認担当者コード")]
        public string? HonshaShoninShaCd { get; set; }

        [Column("HONSHA_SHONIN_SHOZOKU_CD")]
        [Display(Name = "本社承認所属コード")]
        public string? HonshaShoninShozokuCd { get; set; }

        [Column("HONSHA_SHONIN_SHOZOKU_NM")]
        [Display(Name = "本社承認所属名")]
        public string? HonshaShoninShozokuNm { get; set; }

        [Column("HONSHA_SHONIN_JOTAI_KBN")]
        [Display(Name = "本社承認状態区分")]
        public string? HonshaShoninJotaiKbn { get; set; }

        [Column("HONSHA_SHONIN_YMD")]
        [Display(Name = "本社承認年月日")]
        public string? HonshaShoninYmd { get; set; }

        [Column("HONSHA_SHONIN_HMS")]
        [Display(Name = "本社承認時間")]
        public string? HonshaShoninHms { get; set; }

        [Column("NYUKIN_RENKEI_SEIKYU_KBN")]
        [Display(Name = "入金連携請求区分")]
        public string? NyukinRenkeiSeikyuKbn { get; set; }

        [Column("NYUKIN_RENKEI_SEIKYU_CD")]
        [Display(Name = "入金連携請求コード")]
        public string? NyukinRenkeiSeikyuCd { get; set; }

        [Column("NYUKIN_RENKEI_SIME_YMD")]
        [Display(Name = "入金連携締年月日")]
        public string? NyukinRenkeiSimeYmd { get; set; }

        [Column("TEISEI_DENPYO_KBN")]
        [Display(Name = "訂正伝票区分")]
        public string? TeiseiDenpyoKbn { get; set; }

        [Column("FURIKOMI_MEISAI_PRINT_SHA_CD")]
        [Display(Name = "振込明細出力者CD")]
        public string? FurikomiMeisaiPrintShaCd { get; set; }

        [Column("FURIKOMI_MEISAI_PRINT_YMD")]
        [Display(Name = "振込明細出力年月日")]
        public string? FurikomiMeisaiPrintYmd { get; set; }

        [Column("FURIKOMI_MEISAI_PRINT_HMS")]
        [Display(Name = "振込明細出力時間")]
        public string? FurikomiMeisaiPrintHms { get; set; }

        [Column("FURIKOMI_MEISAI_PRINT_COUNT")]
        [Display(Name = "振込明細出力回数")]
        public int? FurikomiMeisaiPrintCount { get; set; }

        [Column("SIWAKE_RENKEI_KAKUTEI_NO")]
        [Display(Name = "仕訳連携代表確定記号")]
        public string? SiwakeRenkeiKakuteiNo { get; set; }

        [Column("SIWAKE_RENKEI_KANRI_NO")]
        [Display(Name = "仕訳連携管理番号")]
        public int? SiwakeRenkeiKanriNo { get; set; }

        [Column("SIWAKE_RENKEI_SOSIN_SHA")]
        [Display(Name = "仕訳連携データ送信者")]
        public string? SiwakeRenkeiSosinSha { get; set; }

        [Column("SIWAKE_RENKEI_SOSIN_YMD")]
        [Display(Name = "仕訳連携データ送信日")]
        public string? SiwakeRenkeiSosinYmd { get; set; }

        [Column("SIWAKE_RENKEI_SOSIN_HMS")]
        [Display(Name = "仕訳連携データ送信時間")]
        public string? SiwakeRenkeiSosinHms { get; set; }

        [Column("SIWAKE_RENKEI_KAKUNIN_SHA")]
        [Display(Name = "仕訳連携データ確認者")]
        public string? SiwakeRenkeiKakuninSha { get; set; }

        [Column("SIWAKE_RENKEI_KAKUNIN_YMD")]
        [Display(Name = "仕訳連携データ確認日")]
        public string? SiwakeRenkeiKakuninYmd { get; set; }

        [Column("SIWAKE_RENKEI_KAKUNIN_HMS")]
        [Display(Name = "仕訳連携データ確認時間")]
        public string? SiwakeRenkeiKakuninHms { get; set; }

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
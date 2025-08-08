using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    public class Sample
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "名称")]
        public required string Name { get; set; }

        [Range(0, 10000)]
        [Display(Name = "価格")]
        public decimal Price { get; set; }

        [Display(Name = "説明")]
        public string? Description { get; set; }

        [Range(0, int.MaxValue)]
        [Display(Name = "数量")]
        public int? Quantity { get; set; }

        [Range(0.0, double.MaxValue)]
        [Display(Name = "重量")]
        public double? Weight { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "対象年月")]
        public DateOnly? TargetYM { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "支払日")]
        public DateOnly? PaymentDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "更新日時")]
        public DateTime? UpdatedAt { get; set; }

        [Display(Name = "状態")]
        public bool? IsActive { get; set; }

        [NotMapped]
        public string IsActiveDisplay => IsActive == true ? "有効" : "無効";

        [StringLength(100)]
        [Display(Name = "文字1")]
        public string? Text1 { get; set; }

        [StringLength(100)]
        [Display(Name = "文字2")]
        public string? Text2 { get; set; }

        [StringLength(100)]
        [Display(Name = "文字3")]
        public string? Text3 { get; set; }

        [StringLength(100)]
        [Display(Name = "文字4")]
        public string? Text4 { get; set; }

        [StringLength(100)]
        [Display(Name = "文字5")]
        public string? Text5 { get; set; }
    }

    [Display(Name = "販促費申請情報")]
    public class HansokuSinsei
    {
        [Column("KAISHA_CD")]
        [Display(Name = "会社CD")]
        public required string KaishaCd { get; set; }

        [Column("URIKAKE_BUNRUI")]
        [Display(Name = "売掛分類")]
        public required string UrikakeBunrui { get; set; }

        [NotMapped]
        [Display(Name = "売掛分類")]
        public string UrikakeBunruiNm => UrikakeBunrui switch
        {
            "1" => "特約店",
            "4" => "登録店",
            _ => string.Empty
        };

        [Column("SEIKYU_KBN")]
        [Display(Name = "請求区分")]
        public required string SeikyuKbn { get; set; }

        [Column("SINSEI_NO")]
        [Display(Name = "申請番号")]
        public required string SinseiNo { get; set; }

        [Column("SINSEI_SHURUI")]
        [Display(Name = "申請種類")]
        public string? SinseiShurui { get; set; }

        [Column("SHUSEI_SINSEI_NO")]
        [Display(Name = "修正元申請番号")]
        public string? ShuseiSinseiNo { get; set; }

        [Column("SINSEI_TAISHO_YM")]
        [Display(Name = "対象年月")]
        public string? SinseiTaishoYm { get; set; }

        [Column("SINSEI_KEIJO_YM")]
        [Display(Name = "計上年月")]
        public string? SinseiKeijoYm { get; set; }

        [Column("KAIKEI_KEIJO_YM")]
        [Display(Name = "会計計上年月")]
        public string? KaikeiKeijoYm { get; set; }

        [Column("SINSEI_KAGAMI_NO")]
        [Display(Name = "申請鑑番号")]
        public string? SinseiKagamiNo { get; set; }

        [Column("SINSEI_KAGAMI_DAIHYO_NO")]
        [Display(Name = "申請鑑代表番号")]
        public string? SinseiKagamiDaihyoNo { get; set; }

        [Column("SINSEI_KAGAMI_DAIHYO_CD")]
        [Display(Name = "申請鑑代表CD")]
        public string? SinseiKagamiDaihyoCd { get; set; }

        [Column("SINSEI_SIHARAI_GROUP_CD")]
        [Display(Name = "支払グループCD")]
        public string? SinseiSiharaiGroupCd { get; set; }

        [Column("SINSEI_SEIKYU_CD")]
        [Display(Name = "請求先CD")]
        public string? SinseiSeikyuCd { get; set; }

        [Column("SINSEI_SEIKYU_NM")]
        [Display(Name = "請求先名")]
        public string? SinseiSeikyuNm { get; set; }

        [Column("SINSEI_SEIKYU_BUNRUI_CD")]
        [Display(Name = "請求先店分類CD")]
        public byte? SinseiSeikyuBunruiCd { get; set; }

        [Column("SINSEI_CHOAI_CD")]
        [Display(Name = "帳合CD")]
        public string? SinseiChoaiCd { get; set; }

        [Column("SINSEI_CHOAI_NM")]
        [Display(Name = "帳合名")]
        public string? SinseiChoaiNm { get; set; }

        [Column("SINSEI_CHOAI_BUNRUI_CD")]
        [Display(Name = "帳合店分類CD")]
        public byte? SinseiChoaiBunruiCd { get; set; }

        [Column("SINSEI_SEIKYU_HONTEN_CD")]
        [Display(Name = "請求先本店CD")]
        public string? SinseiSeikyuHontenCd { get; set; }

        [Column("SINSEI_SEIKYU_HONTEN_NM")]
        [Display(Name = "請求先本店名")]
        public string? SinseiSeikyuHontenNm { get; set; }

        [Column("SINSEI_SEIKYU_SIMEBI")]
        [Display(Name = "請求先締日通常")]
        public string? SinseiSeikyuSimebi { get; set; }

        [Column("SINSEI_SEIKYU_SHUKIN_BI")]
        [Display(Name = "請求先集金日通常")]
        public string? SinseiSeikyuShukinBi { get; set; }

        [Column("SINSEI_SEIKYU_KAISHU_SITE")]
        [Display(Name = "請求先回収サイト")]
        public string? SinseiSeikyuKaishuSite { get; set; }

        [Column("SINSEI_SEIKYU_LAST_SIMEBI")]
        [Display(Name = "請求先最終締処理日")]
        public string? SinseiSeikyuLastSimebi { get; set; }

        [Column("KIKAKU_BUNRUI_NO")]
        [Display(Name = "企画分類番号")]
        public string? KikakuBunruiNo { get; set; }

        [Column("TORIHIKI_CD_A")]
        [Display(Name = "得意先CD_A")]
        public string? TorihikiCdA { get; set; }

        [Column("TORIHIKI_NM_A")]
        [Display(Name = "得意先名")]
        public string? TorihikiNmA { get; set; }

        [Column("TORIHIKI_KANA_A")]
        [Display(Name = "得意先ｶﾅ_A")]
        public string? TorihikiKanaA { get; set; }

        [Column("TORIHIKI_BUNRUI_CD")]
        [Display(Name = "得意先店分類CD")]
        public byte? TorihikiBunruiCd { get; set; }

        [Column("TORIHIKI_GYOTAI_KBN")]
        [Display(Name = "得意先業態区分")]
        public string? TorihikiGyotaiKbn { get; set; }

        [Column("TORIHIKI_CD_KBN")]
        [Display(Name = "得意先CD区分")]
        public string? TorihikiCdKbn { get; set; }

        [Column("TORIHIKI_CD_B")]
        [Display(Name = "得意先CD_B")]
        public string? TorihikiCdB { get; set; }

        [Column("TORIHIKI_KANJI_KBN")]
        [Display(Name = "得意先名漢字区分")]
        public string? TorihikiKanjiKbn { get; set; }

        [Column("TORIHIKI_NM_B")]
        [Display(Name = "得意先名_B")]
        public string? TorihikiNmB { get; set; }

        [Column("TORIHIKI_AREA_CD")]
        [Display(Name = "得意先エリアCD")]
        public string? TorihikiAreaCd { get; set; }

        [Column("TORIHIKI_BUSHO_CD")]
        [Display(Name = "得意先部署CD")]
        public string? TorihikiBushoCd { get; set; }

        [Column("TORIHIKI_EIGYO_CD")]
        [Display(Name = "得意先営業CD")]
        public string? TorihikiEigyoCd { get; set; }

        [Column("TORIHIKI_CENTER_CD")]
        [Display(Name = "得意先物流センターCD")]
        public string? TorihikiCenterCd { get; set; }

        [Column("TORIHIKI_KEIYAKU_NO")]
        [Display(Name = "得意先契約書番号")]
        public string? TorihikiKeiyakuNo { get; set; }

        [Column("TORIHIKI_KEIYAKU_HOZON")]
        [Display(Name = "得意先契約書保存先")]
        public string? TorihikiKeiyakuHozon { get; set; }

        [Column("TORIHIKI_MITUMORI_NO")]
        [Display(Name = "得意先見積書番号")]
        public string? TorihikiMitumoriNo { get; set; }

        [Column("TORIHIKI_MITUMORI_HOZON")]
        [Display(Name = "得意先見積書番号保存先")]
        public string? TorihikiMitumoriHozon { get; set; }

        [Column("TORIHIKI_MISHU_SEIKYU_NO")]
        [Display(Name = "得意先未収請求書番号")]
        public string? TorihikiMishuSeikyuNo { get; set; }

        [Column("TORIHIKI_MISHU_SEIKYU_HOZON")]
        [Display(Name = "得意先未収請求書保存先")]
        public string? TorihikiMishuSeikyuHozon { get; set; }

        [Column("TORIHIKI_MISHU_NO")]
        [Display(Name = "得意先未収番号")]
        public string? TorihikiMishuNo { get; set; }

        [Column("TORIHIKI_SEIKYU_SIME")]
        [Display(Name = "請求締日")]
        public string? TorihikiSeikyuSime { get; set; }

        [Column("SIHARAI_KEITAI")]
        [Display(Name = "支払形態")]
        public string? SiharaiKeitai { get; set; }

        [Column("SIHARAI_SHUBETU")]
        [Display(Name = "支払種別")]
        public string? SiharaiShubetu { get; set; }

        [NotMapped]
        [Display(Name = "処理方法")]
        public string ShoriHoho =>
            SiharaiKeitai switch
            {
                var k when k != null && k.StartsWith("1") => "請求書控除",
                var k when k != null && k.StartsWith("2") => "売掛金相殺",
                var k when k != null && k.StartsWith("3") => SiharaiShubetu switch
                {
                    "1" => "振込（請求・帳合）",
                    "2" => "振込（得意先）",
                    _ => string.Empty
                },
                _ => string.Empty
            };

        [Column("SIHARAI_YOTEI_YMD")]
        [Display(Name = "支払予定日")]
        public string? SiharaiYoteiYmd { get; set; }

        [Column("SIHARAI_KAKUTEI_YMD")]
        [Display(Name = "支払確定日")]
        public string? SiharaiKakuteiYmd { get; set; }

        [Column("SIHARAI_TETUZUKI_SHO_CD")]
        [Display(Name = "支払手続所CD")]
        public string? SiharaiTetuzukiShoCd { get; set; }

        [Column("SIHARAI_TETUZUKI_SHA_CD")]
        [Display(Name = "支払手続者CD")]
        public string? SiharaiTetuzukiShaCd { get; set; }

        [Column("SIHARAI_TETUZUKI_YMD")]
        [Display(Name = "支払手続日")]
        public string? SiharaiTetuzukiYmd { get; set; }

        [Column("SIHARAI_TETUZUKI_TIME")]
        [Display(Name = "支払手続時間")]
        public string? SiharaiTetuzukiTime { get; set; }

        [Column("MIBARAI_KANRI_KBN")]
        [Display(Name = "未払管理区分")]
        public string? MibaraiKanriKbn { get; set; }

        [Column("MIBARAI_KANRI_SIME")]
        [Display(Name = "未払管理締日")]
        public string? MibaraiKanriSime { get; set; }

        [Column("MIBARAI_KANRI_SHORI_SIME_KBN")]
        [Display(Name = "未払管理処理締区分")]
        public string? MibaraiKanriShoriSimeKbn { get; set; }

        [Column("SIWAKE_KIDEN_YMD")]
        [Display(Name = "仕訳起伝日")]
        public string? SiwakeKidenYmd { get; set; }

        [Column("SINSEI_COMMENT")]
        [Display(Name = "申請者コメント")]
        public string? SinseiComment { get; set; }

        [Column("KYOSAN_COMMENT_HYOSI_FLG")]
        [Display(Name = "協賛内容コメント表紙印字フラグ")]
        public string? KyosanCommentHyosiFlg { get; set; }

        [Column("JOTAI_KBN")]
        [Display(Name = "状態区分")]
        public string? JotaiKbn { get; set; }

        [NotMapped]
        [Display(Name = "状態区分")]
        public string JotaiKbnNm => JotaiKbn switch
        {
            "0" => "申請登録",
            "1" => "鑑作成済",
            "2" => "印刷済",
            "3" => "承認済",
            "4" => "費用計上確定",
            "5" => "支払完了",
            _ => string.Empty
        };

        [NotMapped]
        [Display(Name = "本社承認状態区分")]
        public string HonshaShoninJotaiKbn => "0";

        [Column("KEIHISHO_CD")]
        [Display(Name = "経費所CD")]
        public string? KeihishoCd { get; set; }

        [Column("KEIHISHO_NM")]
        [Display(Name = "経費所")]
        public string? KeihishoNm { get; set; }

        [Column("KEIHISHA_CD")]
        [Display(Name = "経費者CD")]
        public string? KeihishaCd { get; set; }

        [Column("KEIHISHA_NM")]
        [Display(Name = "経費者")]
        public string? KeihishaNm { get; set; }

        [Column("SINSEI_SHO_CD")]
        [Display(Name = "申請所CD")]
        public string? SinseiShoCd { get; set; }

        [Column("SINSEI_SHO_NM")]
        [Display(Name = "申請所")]
        public string? SinseiShoNm { get; set; }

        [Column("SINSEI_SHA_CD")]
        [Display(Name = "申請者CD")]
        public string? SinseiShaCd { get; set; }

        [Column("SINSEI_SHA_NM")]
        [Display(Name = "申請者")]
        public string? SinseiShaNm { get; set; }

        [Column("SINSEI_KAGAMI_SHO_CD")]
        [Display(Name = "鑑申請所CD")]
        public string? SinseiKagamiShoCd { get; set; }

        [Column("SINSEI_KAGAMI_SHO_NM")]
        [Display(Name = "鑑申請所名")]
        public string? SinseiKagamiShoNm { get; set; }

        [Column("SINSEI_KAGAMI_SHA_CD")]
        [Display(Name = "鑑申請者CD")]
        public string? SinseiKagamiShaCd { get; set; }

        [Column("SINSEI_KAGAMI_SHA_NM")]
        [Display(Name = "鑑申請者名")]
        public string? SinseiKagamiShaNm { get; set; }

        [Column("SINSEI_TOROKU_YMD")]
        [Display(Name = "申請登録日")]
        public string? SinseiTorokuYmd { get; set; }

        [Column("SINSEI_TOROKU_TIME")]
        [Display(Name = "申請登録時間")]
        public string? SinseiTorokuTime { get; set; }

        [Column("SINSEI_SHO_SAKUSEI_YMD")]
        [Display(Name = "申請書作成日")]
        public string? SinseiShoSakuseiYmd { get; set; }

        [Column("SINSEI_SHO_SAKUSEI_TIME")]
        [Display(Name = "申請書作成時間")]
        public string? SinseiShoSakuseiTime { get; set; }

        [Column("SINSEI_SHO_SAKUSEI_YMD_ZENKAI")]
        [Display(Name = "申請書作成日前回")]
        public string? SinseiShoSakuseiYmdZenkai { get; set; }

        [Column("SINSEI_SHO_SAKUSEI_TIME_ZENKAI")]
        [Display(Name = "申請書作成時間前回")]
        public string? SinseiShoSakuseiTimeZenkai { get; set; }

        [Column("SINSEI_SHO_INSATU_YMD")]
        [Display(Name = "申請書印刷要求日")]
        public string? SinseiShoInsatuYmd { get; set; }

        [Column("SINSEI_SHO_INSATU_TIME")]
        [Display(Name = "申請書要求時間")]
        public string? SinseiShoInsatuTime { get; set; }

        [Column("SINSEI_SHO_INSATU_CNT")]
        [Display(Name = "申請書要求回数")]
        public short? SinseiShoInsatuCnt { get; set; }

        [Column("SURYO_TANI_KBN")]
        [Display(Name = "数量単位区分")]
        public string? SuryoTaniKbn { get; set; }

        [Column("KYOSAN_JOKEN_TANI_KBN")]
        [Display(Name = "協賛条件単位区分")]
        public string? KyosanJokenTaniKbn { get; set; }

        [Column("KYOSAN_GAKU")]
        [Display(Name = "協賛額")]
        public decimal? KyosanGaku { get; set; }

        [Column("KYOSAN_GAKU_ZEI_KBN")]
        [Display(Name = "協賛額消費税区分")]
        public required string KyosanGakuZeiKbn { get; set; }

        [Column("KYOSAN_GAKU_ZEI_GAKU")]
        [Display(Name = "協賛額消費税額")]
        public decimal? KyosanGakuZeiGaku { get; set; }

        [Column("KYOSAN_GAKU_ZEI_NUKI")]
        [Display(Name = "協賛額税抜額")]
        public decimal? KyosanGakuZeiNuki { get; set; }

        [Column("ZEI_HASU_SHORI_KBN")]
        [Display(Name = "消費税端数処理区分")]
        public required string ZeiHasuShoriKbn { get; set; }

        [Column("SINSEI_YMD")]
        [Display(Name = "申請年月日")]
        public string? SinseiYmd { get; set; }

        [Column("TAISHO_KAISI_YMD")]
        [Display(Name = "対象期間開始日")]
        public string? TaishoKaisiYmd { get; set; }

        [Column("TAISHO_SHURYO_YMD")]
        [Display(Name = "対象期間終了日")]
        public string? TaishoShuryoYmd { get; set; }

        [Column("MISE_BUNRUI")]
        [Display(Name = "店分類")]
        public string? MiseBunrui { get; set; }

        [Column("HACCHUSAKI_CD")]
        [Display(Name = "発注先CD")]
        public string? HacchusakiCd { get; set; }

        [Column("HACCHUSAKI_NM")]
        [Display(Name = "発注先名")]
        public string? HacchusakiNm { get; set; }

        [Column("SHUSEI_KBN")]
        [Display(Name = "修正区分")]
        public string? ShuseiKbn { get; set; }

        [Column("SINSEI_ASSOCIATION_CD")]
        [Display(Name = "申請紐づけCD")]
        public string? SinseiAssociationCd { get; set; }

        [Column("TEISEI_SINSEI_NO")]
        [Display(Name = "訂正申請番号")]
        public string? TeiseiSinseiNo { get; set; }

        [Column("TEISEI_MOTO_SINSEI_NO")]
        [Display(Name = "訂正元申請番号")]
        public string? TeiseiMotoSinseiNo { get; set; }

        [Column("CHOFUKU_JOGAI")]
        [Display(Name = "重複除外")]
        public required string ChofukuJogai { get; set; }

        [Column("SHUSEI_KAGAMI_NO")]
        [Display(Name = "修正鑑番号")]
        public string? ShuseiKagamiNo { get; set; }

        [Column("MITUMORI_TEKIYO")]
        [Display(Name = "見積適用")]
        public required string MitumoriTekiyo { get; set; }

        [Column("KAKAKU_HANSOKU_KBN")]
        [Display(Name = "価格販促区分")]
        public required string KakakuHansokuKbn { get; set; }

        [Column("REMARKS")]
        [Display(Name = "備考")]
        public required string Remarks { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "登録者")]
        public required string CreatedId { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "登録日時")]
        public DateTime CreatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "更新者")]
        public required string UpdatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "更新日時")]
        public DateTime UpdatedAt { get; set; }

        [Column("DELETED_FLG")]
        [Display(Name = "削除フラグ")]
        public bool DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "ロックバージョン")]
        public int LockVersion { get; set; }

        [Column("NEBIKI_SYUBETU")]
        [Display(Name = "値引き種別")]
        public required string NebikiSyubetu { get; set; }
    }
}

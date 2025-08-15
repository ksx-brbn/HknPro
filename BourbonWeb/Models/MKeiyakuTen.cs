using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "契約店マスタ")]
    public class MKeiyakuTen
    {
        [Column("KEIYAKU_TEN_TOKUI_CD")]
        [Display(Name = "契約店得意先コード")]
        public string? KeiyakuTenTokuiCd { get; set; }

        [Column("KEIYAKU_KAISI_YM")]
        [Display(Name = "契約開始年月")]
        public string? KeiyakuKaisiYm { get; set; }

        [Column("KEIYAKU_SHURYO_YM")]
        [Display(Name = "契約終了年月")]
        public string? KeiyakuShuryoYm { get; set; }

        [Column("ZENNEN_DOKI_KEIYAKU")]
        [Display(Name = "前年同期契約")]
        public string? ZennenDokiKeiyaku { get; set; }

        [Column("GYOTAI_KBN")]
        [Display(Name = "業態区分")]
        public string? GyotaiKbn { get; set; }

        [Column("MISE_KBN")]
        [Display(Name = "店区分")]
        public string? MiseKbn { get; set; }

        [Column("FORO_KBN")]
        [Display(Name = "フォロー区分")]
        public string? ForoKbn { get; set; }

        [Column("TOKUI_NM")]
        [Display(Name = "得意先名")]
        public string? TokuiNm { get; set; }

        [Column("TOKUI_KANA")]
        [Display(Name = "得意先名カナ")]
        public string? TokuiKana { get; set; }

        [Column("YUBIN")]
        [Display(Name = "郵便番号")]
        public string? Yubin { get; set; }

        [Column("KEN_CD")]
        [Display(Name = "県コード")]
        public string? KenCd { get; set; }

        [Column("JUSHO")]
        [Display(Name = "住所")]
        public string? Jusho { get; set; }

        [Column("TEL_NO")]
        [Display(Name = "電話番号")]
        public string? TelNo { get; set; }

        [Column("FAX_NO")]
        [Display(Name = "ＦＡＸ番号")]
        public string? FaxNo { get; set; }

        [Column("HOME_PAGE")]
        [Display(Name = "ホームページ")]
        public string? HomePage { get; set; }

        [Column("SHACHO_NM")]
        [Display(Name = "社長名")]
        public string? ShachoNm { get; set; }

        [Column("TENPO_SU")]
        [Display(Name = "店舗数")]
        public int? TenpoSu { get; set; }

        [Column("SAKUNEN_HI_ZOGEN_TENSU")]
        [Display(Name = "昨年比増減店数")]
        public int? SakunenHiZogenTensu { get; set; }

        [Column("NENSHO")]
        [Display(Name = "年商")]
        public decimal? Nensho { get; set; }

        [Column("NENSHO_SINCHO_RATE")]
        [Display(Name = "年商伸張率")]
        public decimal? NenshoSinchoRate { get; set; }

        [Column("KASI_NENSHO")]
        [Display(Name = "菓子年商")]
        public decimal? KasiNensho { get; set; }

        [Column("KASI_NENSHO_SINCHO_RATE")]
        [Display(Name = "菓子年商伸張率")]
        public decimal? KasiNenshoSinchoRate { get; set; }

        [Column("SHOKUHIN_NENSHO")]
        [Display(Name = "食品年商")]
        public decimal? ShokuhinNensho { get; set; }

        [Column("SHOKUHIN_NENSHO_SINCHO_RATE")]
        [Display(Name = "食品年商伸張率")]
        public decimal? ShokuhinNenshoSinchoRate { get; set; }

        [Column("NENSHO_NENDO")]
        [Display(Name = "年商年度")]
        public string? NenshoNendo { get; set; }

        [Column("KAMEI_DANTAI_NM")]
        [Display(Name = "加盟団体名")]
        public string? KameiDantaiNm { get; set; }

        [Column("KAMEI_KYODO_SIIRE_KIKO")]
        [Display(Name = "加盟共同仕入機構")]
        public string? KameiKyodoSiireKiko { get; set; }

        [Column("SHOKUHIN_BUCHO")]
        [Display(Name = "食品部長")]
        public string? ShokuhinBucho { get; set; }

        [Column("KASI_TANTO1")]
        [Display(Name = "菓子担当１")]
        public string? KasiTanto1 { get; set; }

        [Column("KASI_TANTO2")]
        [Display(Name = "菓子担当２")]
        public string? KasiTanto2 { get; set; }

        [Column("SHOKUHIN_TANTO1")]
        [Display(Name = "食品担当１")]
        public string? ShokuhinTanto1 { get; set; }

        [Column("SHOKUHIN_TANTO2")]
        [Display(Name = "食品担当２")]
        public string? ShokuhinTanto2 { get; set; }

        [Column("KASI_CHOAI_CD1")]
        [Display(Name = "菓子帳合コード１")]
        public string? KasiChoaiCd1 { get; set; }

        [Column("KASI_CHOAI_CD2")]
        [Display(Name = "菓子帳合コード２")]
        public string? KasiChoaiCd2 { get; set; }

        [Column("KASI_CHOAI_CD3")]
        [Display(Name = "菓子帳合コード３")]
        public string? KasiChoaiCd3 { get; set; }

        [Column("SHOKUHIN_CHOAI_CD1")]
        [Display(Name = "食品帳合コード１")]
        public string? ShokuhinChoaiCd1 { get; set; }

        [Column("SHOKUHIN_CHOAI_CD2")]
        [Display(Name = "食品帳合コード２")]
        public string? ShokuhinChoaiCd2 { get; set; }

        [Column("KASI_CHOAI1")]
        [Display(Name = "菓子帳合１")]
        public string? KasiChoai1 { get; set; }

        [Column("KASI_CHOAI2")]
        [Display(Name = "菓子帳合２")]
        public string? KasiChoai2 { get; set; }

        [Column("KASI_CHOAI3")]
        [Display(Name = "菓子帳合３")]
        public string? KasiChoai3 { get; set; }

        [Column("SHOKUHIN_CHOAI1")]
        [Display(Name = "食品帳合１")]
        public string? ShokuhinChoai1 { get; set; }

        [Column("SHOKUHIN_CHOAI2")]
        [Display(Name = "食品帳合２")]
        public string? ShokuhinChoai2 { get; set; }

        [Column("MTOKUI_CD")]
        [Display(Name = "MTOKUIコード")]
        public string? MtokuiCd { get; set; }

        [Column("TANTO_SHO_CD")]
        [Display(Name = "担当所コード")]
        public string? TantoShoCd { get; set; }

        [Column("TANTO_SHA_CD")]
        [Display(Name = "担当セールスコード")]
        public string? TantoShaCd { get; set; }

        [Column("TANTO_KAISI")]
        [Display(Name = "担当開始")]
        public string? TantoKaisi { get; set; }

        [Column("ZEN_TANTO")]
        [Display(Name = "前任担当")]
        public string? ZenTanto { get; set; }

        [Column("ZEN_TANTO_KAISI")]
        [Display(Name = "前任担当開始")]
        public string? ZenTantoKaisi { get; set; }

        [Column("ZENZEN_TANTO")]
        [Display(Name = "前前任担当")]
        public string? ZenzenTanto { get; set; }

        [Column("ZENZEN_TANTO_KAISI")]
        [Display(Name = "前前任担当開始")]
        public string? ZenzenTantoKaisi { get; set; }

        [Column("JUNI1")]
        [Display(Name = "順位1")]
        public string? Juni1 { get; set; }

        [Column("JUNI2")]
        [Display(Name = "順位2")]
        public string? Juni2 { get; set; }

        [Column("JUNI3")]
        [Display(Name = "順位3")]
        public string? Juni3 { get; set; }

        [Column("JUNI4")]
        [Display(Name = "順位4")]
        public string? Juni4 { get; set; }

        [Column("JUNI5")]
        [Display(Name = "順位5")]
        public string? Juni5 { get; set; }

        [Column("JUNI6")]
        [Display(Name = "順位6")]
        public string? Juni6 { get; set; }

        [Column("JUNI7")]
        [Display(Name = "順位7")]
        public string? Juni7 { get; set; }

        [Column("JUNI8")]
        [Display(Name = "順位8")]
        public string? Juni8 { get; set; }

        [Column("JUNI9")]
        [Display(Name = "順位9")]
        public string? Juni9 { get; set; }

        [Column("JUNI10")]
        [Display(Name = "順位10")]
        public string? Juni10 { get; set; }

        [Column("SHARE1")]
        [Display(Name = "シェアー1")]
        public string? Share1 { get; set; }

        [Column("SHARE2")]
        [Display(Name = "シェアー2")]
        public string? Share2 { get; set; }

        [Column("SHARE3")]
        [Display(Name = "シェアー3")]
        public string? Share3 { get; set; }

        [Column("SHARE4")]
        [Display(Name = "シェアー4")]
        public string? Share4 { get; set; }

        [Column("SHARE5")]
        [Display(Name = "シェアー5")]
        public string? Share5 { get; set; }

        [Column("SHARE6")]
        [Display(Name = "シェアー6")]
        public string? Share6 { get; set; }

        [Column("SHARE7")]
        [Display(Name = "シェアー7")]
        public string? Share7 { get; set; }

        [Column("SHARE8")]
        [Display(Name = "シェアー8")]
        public string? Share8 { get; set; }

        [Column("SHARE9")]
        [Display(Name = "シェアー9")]
        public string? Share9 { get; set; }

        [Column("SHARE10")]
        [Display(Name = "シェアー10")]
        public string? Share10 { get; set; }

        [Column("MOKUHYO1")]
        [Display(Name = "目標1")]
        public decimal? Mokuhyo1 { get; set; }

        [Column("REBATE1")]
        [Display(Name = "リベ1")]
        public decimal? Rebate1 { get; set; }

        [Column("MOKUHYO2")]
        [Display(Name = "目標2")]
        public decimal? Mokuhyo2 { get; set; }

        [Column("REBATE2")]
        [Display(Name = "リベ2")]
        public decimal? Rebate2 { get; set; }

        [Column("MOKUHYO3")]
        [Display(Name = "目標3")]
        public decimal? Mokuhyo3 { get; set; }

        [Column("REBATE3")]
        [Display(Name = "リベ3")]
        public decimal? Rebate3 { get; set; }

        [Column("MOKUHYO4")]
        [Display(Name = "目標4")]
        public decimal? Mokuhyo4 { get; set; }

        [Column("REBATE4")]
        [Display(Name = "リベ4")]
        public decimal? Rebate4 { get; set; }

        [Column("MOKUHYO5")]
        [Display(Name = "目標5")]
        public decimal? Mokuhyo5 { get; set; }

        [Column("REBATE5")]
        [Display(Name = "リベ5")]
        public decimal? Rebate5 { get; set; }

        [Column("MOKUHYO6")]
        [Display(Name = "目標6")]
        public decimal? Mokuhyo6 { get; set; }

        [Column("REBATE6")]
        [Display(Name = "リベ6")]
        public decimal? Rebate6 { get; set; }

        [Column("MOKUHYO7")]
        [Display(Name = "目標7")]
        public decimal? Mokuhyo7 { get; set; }

        [Column("REBATE7")]
        [Display(Name = "リベ7")]
        public decimal? Rebate7 { get; set; }

        [Column("MOKUHYO8")]
        [Display(Name = "目標8")]
        public decimal? Mokuhyo8 { get; set; }

        [Column("REBATE8")]
        [Display(Name = "リベ8")]
        public decimal? Rebate8 { get; set; }

        [Column("MOKUHYO9")]
        [Display(Name = "目標9")]
        public decimal? Mokuhyo9 { get; set; }

        [Column("REBATE9")]
        [Display(Name = "リベ9")]
        public decimal? Rebate9 { get; set; }

        [Column("KEIYAKU_JOHO_HYOJI")]
        [Display(Name = "契約情報表示")]
        public string? KeiyakuJohoHyoji { get; set; }

        [Column("SANSHO_KEIYAKU_CD")]
        [Display(Name = "参照契約店コード")]
        public string? SanshoKeiyakuCd { get; set; }

        [Column("KOSIN_SHA")]
        [Display(Name = "更新者")]
        public string? KosinSha { get; set; }

        [Column("TOROKU_YMD")]
        [Display(Name = "更新日")]
        public string? TorokuYmd { get; set; }

        [Column("TOROKU_TIME")]
        [Display(Name = "更新時刻")]
        public string? TorokuTime { get; set; }

        [Column("DELETE_FLG")]
        [Display(Name = "削除フラグ")]
        public string? DeleteFlg { get; set; }

        [Column("KOSIN_TANMATU")]
        [Display(Name = "更新端末")]
        public string? KosinTanmatu { get; set; }

        [Column("SIN_SEIHIN_KANRI")]
        [Display(Name = "新製品管理")]
        public string? SinSeihinKanri { get; set; }

        [Column("ETC_KANRI1")]
        [Display(Name = "その他管理1")]
        public string? EtcKanri1 { get; set; }

        [Column("ETC_KANRI2")]
        [Display(Name = "その他管理2")]
        public string? EtcKanri2 { get; set; }

        [Column("URIAGE1")]
        [Display(Name = "売上1")]
        public string? Uriage1 { get; set; }

        [Column("URIAGE2")]
        [Display(Name = "売上2")]
        public string? Uriage2 { get; set; }

        [Column("URIAGE3")]
        [Display(Name = "売上3")]
        public string? Uriage3 { get; set; }

        [Column("URIAGE4")]
        [Display(Name = "売上4")]
        public string? Uriage4 { get; set; }

        [Column("URIAGE5")]
        [Display(Name = "売上5")]
        public string? Uriage5 { get; set; }

        [Column("URIAGE6")]
        [Display(Name = "売上6")]
        public string? Uriage6 { get; set; }

        [Column("URIAGE7")]
        [Display(Name = "売上7")]
        public string? Uriage7 { get; set; }

        [Column("URIAGE8")]
        [Display(Name = "売上8")]
        public string? Uriage8 { get; set; }

        [Column("URIAGE9")]
        [Display(Name = "売上9")]
        public string? Uriage9 { get; set; }

        [Column("URIAGE10")]
        [Display(Name = "売上10")]
        public string? Uriage10 { get; set; }

        [Column("AREA_NM1")]
        [Display(Name = "エリア名1")]
        public string? AreaNm1 { get; set; }

        [Column("AREA_NM2")]
        [Display(Name = "エリア名2")]
        public string? AreaNm2 { get; set; }

        [Column("AREA_NM3")]
        [Display(Name = "エリア名3")]
        public string? AreaNm3 { get; set; }

        [Column("AREA_NM4")]
        [Display(Name = "エリア名4")]
        public string? AreaNm4 { get; set; }

        [Column("AREA_NM5")]
        [Display(Name = "エリア名5")]
        public string? AreaNm5 { get; set; }

        [Column("AREA_NM6")]
        [Display(Name = "エリア名6")]
        public string? AreaNm6 { get; set; }

        [Column("AREA_NM7")]
        [Display(Name = "エリア名7")]
        public string? AreaNm7 { get; set; }

        [Column("AREA_NM8")]
        [Display(Name = "エリア名8")]
        public string? AreaNm8 { get; set; }

        [Column("AREA_NM9")]
        [Display(Name = "エリア名9")]
        public string? AreaNm9 { get; set; }

        [Column("AREA_NM10")]
        [Display(Name = "エリア名10")]
        public string? AreaNm10 { get; set; }

        [Column("AREA_TEN_SU1")]
        [Display(Name = "エリア店数1")]
        public string? AreaTenSu1 { get; set; }

        [Column("AREA_TEN_SU2")]
        [Display(Name = "エリア店数2")]
        public string? AreaTenSu2 { get; set; }

        [Column("AREA_TEN_SU3")]
        [Display(Name = "エリア店数3")]
        public string? AreaTenSu3 { get; set; }

        [Column("AREA_TEN_SU4")]
        [Display(Name = "エリア店数4")]
        public string? AreaTenSu4 { get; set; }

        [Column("AREA_TEN_SU5")]
        [Display(Name = "エリア店数5")]
        public string? AreaTenSu5 { get; set; }

        [Column("AREA_TEN_SU6")]
        [Display(Name = "エリア店数6")]
        public string? AreaTenSu6 { get; set; }

        [Column("AREA_TEN_SU7")]
        [Display(Name = "エリア店数7")]
        public string? AreaTenSu7 { get; set; }

        [Column("AREA_TEN_SU8")]
        [Display(Name = "エリア店数8")]
        public string? AreaTenSu8 { get; set; }

        [Column("AREA_TEN_SU9")]
        [Display(Name = "エリア店数9")]
        public string? AreaTenSu9 { get; set; }

        [Column("AREA_TEN_SU10")]
        [Display(Name = "エリア店数10")]
        public string? AreaTenSu10 { get; set; }

        [Column("KIBOBETU_GMS")]
        [Display(Name = "規模別_GMS")]
        public string? KibobetuGms { get; set; }

        [Column("KIBOBETU_SM")]
        [Display(Name = "規模別_SM")]
        public string? KibobetuSm { get; set; }

        [Column("KIBOBETU_DS")]
        [Display(Name = "規模別_DS")]
        public string? KibobetuDs { get; set; }

        [Column("KIBOBETU_KOKYU")]
        [Display(Name = "規模別_高級")]
        public string? KibobetuKokyu { get; set; }

        [Column("KIBOBETU_ETC1")]
        [Display(Name = "規模別_他1")]
        public string? KibobetuEtc1 { get; set; }

        [Column("KIBOBETU_ETC2")]
        [Display(Name = "規模別_他2")]
        public string? KibobetuEtc2 { get; set; }

        [Column("PB_ATUKAI")]
        [Display(Name = "PB扱")]
        public string? PbAtukai { get; set; }

        [Column("PB_KASI_ZENTAI")]
        [Display(Name = "PB菓子全体")]
        public string? PbKasiZentai { get; set; }

        [Column("PB_SHOKUHIN_ZENTAI")]
        [Display(Name = "PB食品全体")]
        public string? PbShokuhinZentai { get; set; }

        [Column("PB_SHOHIN1")]
        [Display(Name = "PB商品1")]
        public string? PbShohin1 { get; set; }

        [Column("PB_SHOHIN2")]
        [Display(Name = "PB商品2")]
        public string? PbShohin2 { get; set; }

        [Column("PB_SHOHIN3")]
        [Display(Name = "PB商品3")]
        public string? PbShohin3 { get; set; }

        [Column("MODEL_TENPO_NM")]
        [Display(Name = "モデル_店舗名")]
        public string? ModelTenpoNm { get; set; }

        [Column("MODEL_YUBIN")]
        [Display(Name = "モデル_郵便")]
        public string? ModelYubin { get; set; }

        [Column("MODEL_KEN_NM")]
        [Display(Name = "モデル_県名")]
        public string? ModelKenNm { get; set; }

        [Column("MODEL_JUSHO")]
        [Display(Name = "モデル_住所")]
        public string? ModelJusho { get; set; }

        [Column("MODEL_TEL")]
        [Display(Name = "モデル_TEL")]
        public string? ModelTel { get; set; }

        [Column("MODEL_FAX")]
        [Display(Name = "モデル_FAX")]
        public string? ModelFax { get; set; }

        [Column("MODEL_URIBA_MENSEKI")]
        [Display(Name = "モデル_売場面積")]
        public string? ModelUribaMenseki { get; set; }

        [Column("MODEL_REGI_DAISU")]
        [Display(Name = "モデル_レジ台数")]
        public string? ModelRegiDaisu { get; set; }

        [Column("MODEL_NYUTEN_KYAKUSU")]
        [Display(Name = "モデル_入店客数")]
        public string? ModelNyutenKyakusu { get; set; }

        [Column("MODEL_KASI_HONSU")]
        [Display(Name = "モデル_菓子本数")]
        public string? ModelKasiHonsu { get; set; }

        [Column("MODEL_KASI_DANSU")]
        [Display(Name = "モデル_菓子段数")]
        public string? ModelKasiDansu { get; set; }

        [Column("MODEL_SHAKUSU")]
        [Display(Name = "モデル_尺数")]
        public string? ModelShakusu { get; set; }

        [Column("MODEL_ZENTAI_KASI_TEI_ITEM")]
        [Display(Name = "モデル_全体菓子定番アイテム")]
        public string? ModelZentaiKasiTeiItem { get; set; }

        [Column("MODEL_ZENTAI_KASI_TEI_FACE")]
        [Display(Name = "モデル_全体菓子定番フェース")]
        public string? ModelZentaiKasiTeiFace { get; set; }

        [Column("MODEL_JISHA_KASI_TEI_ITEM")]
        [Display(Name = "モデル_自社菓子定番アイテム")]
        public string? ModelJishaKasiTeiItem { get; set; }

        [Column("MODEL_JISHA_KASI_TEI_FACE")]
        [Display(Name = "モデル_自社菓子定番フェース")]
        public string? ModelJishaKasiTeiFace { get; set; }

        [Column("MODEL_KOSIN_TUKI")]
        [Display(Name = "モデル_更新月")]
        public string? ModelKosinTuki { get; set; }

        [Column("TOKUI_OYA_CD")]
        [Display(Name = "得意先親CD")]
        public string? TokuiOyaCd { get; set; }
    }
}
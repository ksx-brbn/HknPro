using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "得意先マスタ")]
    public class MTokui
    {
        [Column("KY_TOKUI_CD")]
        [Display(Name = "得意先CD")]
        public string? KyTokuiCd { get; set; }

        [Column("KY_KAISI_YMD")]
        [Display(Name = "開始年月日")]
        public string? KyKaisiYmd { get; set; }

        [Column("KY_SHURYO_YMD")]
        [Display(Name = "終了年月日")]
        public string? KyShuryoYmd { get; set; }

        [Column("TOKUI_NM")]
        [Display(Name = "得意先名")]
        public string? TokuiNm { get; set; }

        [Column("TOKUI_KANA")]
        [Display(Name = "得意先名カナ")]
        public string? TokuiKana { get; set; }

        [Column("TOKUI_RYAKU")]
        [Display(Name = "得意先略称")]
        public string? TokuiRyaku { get; set; }

        [Column("TOKUI_RYAKU_KANA")]
        [Display(Name = "得意先略称カナ")]
        public string? TokuiRyakuKana { get; set; }

        [Column("KEN_NM")]
        [Display(Name = "県名")]
        public string? KenNm { get; set; }

        [Column("SICHOSON_NM")]
        [Display(Name = "市町村名")]
        public string? SichosonNm { get; set; }

        [Column("JUSHO_KANA")]
        [Display(Name = "住所カナ")]
        public string? JushoKana { get; set; }

        [Column("DAIHYO_DAIHYO_BUNRUI")]
        [Display(Name = "代表分類")]
        public string? DaihyoDaihyoBunrui { get; set; }

        [Column("DAIHYO_NM")]
        [Display(Name = "代表名")]
        public string? DaihyoNm { get; set; }

        [Column("DAIHYO_BIRTHDAY")]
        [Display(Name = "代表誕生日")]
        public string? DaihyoBirthday { get; set; }

        [Column("DAIHYO_TOKI")]
        [Display(Name = "代表特記事項")]
        public string? DaihyoToki { get; set; }

        [Column("SICHOSON_CD")]
        [Display(Name = "市町村CD")]
        public string? SichosonCd { get; set; }

        [Column("SHUKA_SOKO_CD")]
        [Display(Name = "出荷倉庫CD")]
        public string? ShukaSokoCd { get; set; }

        [Column("YUBIN_UE")]
        [Display(Name = "郵便(上)")]
        public string? YubinUe { get; set; }

        [Column("YUBIN_SITA")]
        [Display(Name = "郵便(下)")]
        public string? YubinSita { get; set; }

        [Column("TEL_NO1")]
        [Display(Name = "電話番号1")]
        public string? TelNo1 { get; set; }

        [Column("TEL_NO2")]
        [Display(Name = "電話番号2")]
        public string? TelNo2 { get; set; }

        [Column("FAX_NO1")]
        [Display(Name = "FAX1")]
        public string? FaxNo1 { get; set; }

        [Column("FAX_NO2")]
        [Display(Name = "FAX2")]
        public string? FaxNo2 { get; set; }

        [Column("MISE_BUNRUI")]
        [Display(Name = "店分類")]
        public byte? MiseBunrui { get; set; }

        [Column("BLOCK_CD")]
        [Display(Name = "ブロックCD")]
        public string? BlockCd { get; set; }

        [Column("CHUSI_BUNRUI")]
        [Display(Name = "中止分類")]
        public string? ChusiBunrui { get; set; }

        [Column("CHUSI_JITEN")]
        [Display(Name = "中止時点")]
        public string? ChusiJiten { get; set; }

        [Column("SEIKYU_KEIRO_BUNRUI")]
        [Display(Name = "請求経路分類")]
        public string? SeikyuKeiroBunrui { get; set; }

        [Column("EIGYO_KEIRO_BUNRUI1")]
        [Display(Name = "営業経路分類1")]
        public string? EigyoKeiroBunrui1 { get; set; }

        [Column("HONSHA_BUNRUI")]
        [Display(Name = "本社分類")]
        public string? HonshaBunrui { get; set; }

        [Column("GROUP_HONSHA_CD")]
        [Display(Name = "グループ本社CD")]
        public string? GroupHonshaCd { get; set; }

        [Column("BUNSHA_HONSHA_CD")]
        [Display(Name = "分社本社CD")]
        public string? BunshaHonshaCd { get; set; }

        [Column("TOKUI_HONTEN_CD")]
        [Display(Name = "得意先本店CD")]
        public string? TokuiHontenCd { get; set; }

        [Column("TANTO_KBN")]
        [Display(Name = "担当区分")]
        public string? TantoKbn { get; set; }

        [Column("TORIHIKI_KBN")]
        [Display(Name = "取引区分")]
        public string? TorihikiKbn { get; set; }

        [Column("TOKUKAHI_KBN")]
        [Display(Name = "得意先可否区分")]
        public string? TokukahiKbn { get; set; }

        [Column("KINO_BUNRUI")]
        [Display(Name = "機能区分")]
        public string? KinoBunrui { get; set; }

        [Column("FORO_KBN")]
        [Display(Name = "フォロー区分")]
        public string? ForoKbn { get; set; }

        [Column("MISE_RANK")]
        [Display(Name = "店ランク")]
        public string? MiseRank { get; set; }

        [Column("REGYUTAI_MISE_KBN")]
        [Display(Name = "レギュラー態店区分")]
        public string? RegyutaiMiseKbn { get; set; }

        [Column("CHOKUTAI_MISE_KBN")]
        [Display(Name = "直態店区分")]
        public string? ChokutaiMiseKbn { get; set; }

        [Column("JUCHU_KAHI_KBN")]
        [Display(Name = "受注可否区分")]
        public string? JuchuKahiKbn { get; set; }

        [Column("JUCHU_CHOSEI_KBN")]
        [Display(Name = "受注調整区分")]
        public string? JuchuChoseiKbn { get; set; }

        [Column("SENDO_YOKYU_KBN")]
        [Display(Name = "鮮度要求区分")]
        public string? SendoYokyuKbn { get; set; }

        [Column("NOHIN_JIKAN_SITEITEN")]
        [Display(Name = "納品時間指定店")]
        public string? NohinJikanSiteiten { get; set; }

        [Column("NOHIN_SITEI_KAISI")]
        [Display(Name = "納品指定開始")]
        public string? NohinSiteiKaisi { get; set; }

        [Column("NOHIN_SITEI_SHURYO")]
        [Display(Name = "納品指定終了")]
        public string? NohinSiteiShuryo { get; set; }

        [Column("HOREI_SETUBI_UMU")]
        [Display(Name = "法令設備有無")]
        public string? HoreiSetubiUmu { get; set; }

        [Column("TEIKYUBI")]
        [Display(Name = "定休日")]
        public string? Teikyubi { get; set; }

        [Column("FORO_BL_CD")]
        [Display(Name = "フォローブロックCD")]
        public string? ForoBlCd { get; set; }

        [Column("NENSHO")]
        [Display(Name = "年商")]
        public int? Nensho { get; set; }

        [Column("SENDENPYO_KBN")]
        [Display(Name = "専伝票区分")]
        public string? SendenpyoKbn { get; set; }

        [Column("KASI_VAN_CD")]
        [Display(Name = "菓子VANCD")]
        public string? KasiVanCd { get; set; }

        [Column("KASI_SHODAN_KATAGAKI")]
        [Display(Name = "菓子商談肩書")]
        public string? KasiShodanKatagaki { get; set; }

        [Column("KASI_SHODAN_NM")]
        [Display(Name = "菓子商談名")]
        public string? KasiShodanNm { get; set; }

        [Column("KASI_SHODAN_BIRTHDAY")]
        [Display(Name = "菓子商談誕生日")]
        public string? KasiShodanBirthday { get; set; }

        [Column("KASI_SHODAN_TOKI")]
        [Display(Name = "菓子商談特記事項")]
        public string? KasiShodanToki { get; set; }

        [Column("KASI_SHOJO_KATAGAKI")]
        [Display(Name = "菓子書状肩書")]
        public string? KasiShojoKatagaki { get; set; }

        [Column("KASI_SHOJO_NM")]
        [Display(Name = "菓子書状名")]
        public string? KasiShojoNm { get; set; }

        [Column("KASI_SHOJO_BIRTHDAY")]
        [Display(Name = "菓子書状誕生日")]
        public string? KasiShojoBirthday { get; set; }

        [Column("KASI_SHOJO_TOKI")]
        [Display(Name = "菓子書状特記事項")]
        public string? KasiShojoToki { get; set; }

        [Column("KASI_NENURI")]
        [Display(Name = "菓子年売")]
        public int? KasiNenuri { get; set; }

        [Column("KASI_URITAN_SHO_CD")]
        [Display(Name = "菓子売担当所CD")]
        public string? KasiUritanShoCd { get; set; }

        [Column("KASI_URITAN_SHA_CD")]
        [Display(Name = "菓子売担当者CD")]
        public string? KasiUritanShaCd { get; set; }

        [Column("KASI_FO_SHO_CD")]
        [Display(Name = "菓子フォロー所CD")]
        public string? KasiFoShoCd { get; set; }

        [Column("KASI_FO_SHA_CD")]
        [Display(Name = "菓子フォロー者CD")]
        public string? KasiFoShaCd { get; set; }

        [Column("KASI_CHOAI_CD")]
        [Display(Name = "菓子帳合CD")]
        public string? KasiChoaiCd { get; set; }

        [Column("KASI_2CHOAI_CD")]
        [Display(Name = "菓子2帳合CD")]
        public string? Kasi2ChoaiCd { get; set; }

        [Column("KASI_3CHOAI_CD")]
        [Display(Name = "菓子3帳合CD")]
        public string? Kasi3ChoaiCd { get; set; }

        [Column("KASI_ETC_CHOAI1")]
        [Display(Name = "菓子ETC帳合1")]
        public string? KasiEtcChoai1 { get; set; }

        [Column("KASI_ETC_CHOAI2")]
        [Display(Name = "菓子ETC帳合2")]
        public string? KasiEtcChoai2 { get; set; }

        [Column("KASI_ETC_CHOAI3")]
        [Display(Name = "菓子ETC帳合3")]
        public string? KasiEtcChoai3 { get; set; }

        [Column("KASI_KAISI_YMD")]
        [Display(Name = "菓子開始年月日")]
        public string? KasiKaisiYmd { get; set; }

        [Column("KASI_CHUSI_YMD")]
        [Display(Name = "菓子終了年月日")]
        public string? KasiChusiYmd { get; set; }

        [Column("KASI_SAISHU_HOMON_YMD")]
        [Display(Name = "菓子最終訪問年月日")]
        public string? KasiSaishuHomonYmd { get; set; }

        [Column("INRYO_SHODAN_KATAGAKI")]
        [Display(Name = "飲料商談肩書")]
        public string? InryoShodanKatagaki { get; set; }

        [Column("INRYO_SHODAN_NM")]
        [Display(Name = "飲料商談名")]
        public string? InryoShodanNm { get; set; }

        [Column("INRYO_SHODAN_BIRTHDAY")]
        [Display(Name = "飲料商談誕生日")]
        public string? InryoShodanBirthday { get; set; }

        [Column("INRYO_SHODAN_TOKI")]
        [Display(Name = "飲料商談特記事項")]
        public string? InryoShodanToki { get; set; }

        [Column("INRYO_SHOJO_KATAGAKI")]
        [Display(Name = "飲料書状肩書")]
        public string? InryoShojoKatagaki { get; set; }

        [Column("INRYO_SHOJO_NM")]
        [Display(Name = "飲料書状名")]
        public string? InryoShojoNm { get; set; }

        [Column("INRYO_SHOJO_BIRTHDAY")]
        [Display(Name = "飲料書状誕生日")]
        public string? InryoShojoBirthday { get; set; }

        [Column("INRYO_SHOJO_TOKI")]
        [Display(Name = "飲料書状特記事項")]
        public string? InryoShojoToki { get; set; }

        [Column("INRYO_NENURI")]
        [Display(Name = "飲料年売")]
        public int? InryoNenuri { get; set; }

        [Column("INRYO_URITAN_SHO_CD")]
        [Display(Name = "飲料売担当所CD")]
        public string? InryoUritanShoCd { get; set; }

        [Column("INRYO_URITAN_SHA_CD")]
        [Display(Name = "飲料売担当者CD")]
        public string? InryoUritanShaCd { get; set; }

        [Column("INRYO_FO_SHO_CD")]
        [Display(Name = "飲料フォロー所CD")]
        public string? InryoFoShoCd { get; set; }

        [Column("INRYO_FO_SHA_CD")]
        [Display(Name = "飲料フォロー者CD")]
        public string? InryoFoShaCd { get; set; }

        [Column("INRYO_CHOAI_CD")]
        [Display(Name = "飲料帳合CD")]
        public string? InryoChoaiCd { get; set; }

        [Column("INRYO_2CHOAI_CD")]
        [Display(Name = "飲料2帳合CD")]
        public string? Inryo2ChoaiCd { get; set; }

        [Column("INRYO_3CHOAI_CD")]
        [Display(Name = "飲料3帳合CD")]
        public string? Inryo3ChoaiCd { get; set; }

        [Column("INRYO_ETC_CHOAI1")]
        [Display(Name = "飲料ETC帳合1")]
        public string? InryoEtcChoai1 { get; set; }

        [Column("INRYO_ETC_CHOAI2")]
        [Display(Name = "飲料ETC帳合2")]
        public string? InryoEtcChoai2 { get; set; }

        [Column("INRYO_ETC_CHOAI3")]
        [Display(Name = "飲料ETC帳合3")]
        public string? InryoEtcChoai3 { get; set; }

        [Column("INRYO_KAISI_YMD")]
        [Display(Name = "飲料開始年月日")]
        public string? InryoKaisiYmd { get; set; }

        [Column("INRYO_CHUSI_YMD")]
        [Display(Name = "飲料終了年月日")]
        public string? InryoChusiYmd { get; set; }

        [Column("INRYO_SAISHU_HOMON_YMD")]
        [Display(Name = "飲料最終年月日")]
        public string? InryoSaishuHomonYmd { get; set; }

        [Column("DM_KBN")]
        [Display(Name = "DM区分")]
        public string? DmKbn { get; set; }

        [Column("JURYO_UMU")]
        [Display(Name = "重量有無")]
        public string? JuryoUmu { get; set; }

        [Column("SENYO_DENPYO_CD")]
        [Display(Name = "専用伝票CD")]
        public string? SenyoDenpyoCd { get; set; }

        [Column("KASI_RIKEISANHON_CD")]
        [Display(Name = "菓子理計算本店CD")]
        public string? KasiRikeisanhonCd { get; set; }

        [Column("KASI_DAIRITEN_CD")]
        [Display(Name = "菓子代理店CD")]
        public string? KasiDairitenCd { get; set; }

        [Column("KASI_KAISHU_TANTOSHO_CD")]
        [Display(Name = "菓子回収担当所CD")]
        public string? KasiKaishuTantoshoCd { get; set; }

        [Column("KASI_KAISHU_TANTOSHA_CD")]
        [Display(Name = "菓子回収担当者CD")]
        public string? KasiKaishuTantoshaCd { get; set; }

        [Column("KASI_SEIKYU_TANI_CD")]
        [Display(Name = "菓子請求単位CD")]
        public string? KasiSeikyuTaniCd { get; set; }

        [Column("KASI_SEIKYU_SIMEBI")]
        [Display(Name = "菓子請求締日")]
        public string? KasiSeikyuSimebi { get; set; }

        [Column("KASI_SHUKIN_BI")]
        [Display(Name = "菓子集金日")]
        public string? KasiShukinBi { get; set; }

        [Column("KASI_KAISHU_SITE")]
        [Display(Name = "菓子回収指定日")]
        public string? KasiKaishuSite { get; set; }

        [Column("INRYO_SEIKYU_TANI_CD")]
        [Display(Name = "飲料請求単位CD")]
        public string? InryoSeikyuTaniCd { get; set; }

        [Column("INRYO_KAISHU_TANTOSHO_CD")]
        [Display(Name = "飲料回収担当所CD")]
        public string? InryoKaishuTantoshoCd { get; set; }

        [Column("INRYO_KAISHU_TANTOSHA_CD")]
        [Display(Name = "飲料回収担当者CD")]
        public string? InryoKaishuTantoshaCd { get; set; }

        [Column("INRYO_SEIKYU_SIMEBI")]
        [Display(Name = "飲料請求締日")]
        public string? InryoSeikyuSimebi { get; set; }

        [Column("INRYO_SHUKIN_BI")]
        [Display(Name = "飲料集金日")]
        public string? InryoShukinBi { get; set; }

        [Column("INRYO_KAISHU_SITE")]
        [Display(Name = "飲料回収指定日")]
        public string? InryoKaishuSite { get; set; }

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

        [Column("KASI_SEIKYU_SIMEBI2")]
        [Display(Name = "菓子請求締日2")]
        public string? KasiSeikyuSimebi2 { get; set; }

        [Column("INRYO_SEIKYU_SIMEBI2")]
        [Display(Name = "飲料請求締日2")]
        public string? InryoSeikyuSimebi2 { get; set; }

        [Column("KASI_SIMEBI_NENMATU")]
        [Display(Name = "菓子締日年末")]
        public string? KasiSimebiNenMatu { get; set; }

        [Column("INRYO_SIMEBI_NENMATU")]
        [Display(Name = "飲料締日年末")]
        public string? InryoSimebiNenMatu { get; set; }

        [Column("KASI_SHUKIN_BI2")]
        [Display(Name = "菓子集金日2")]
        public string? KasiShukinBi2 { get; set; }

        [Column("INRYO_SHUKIN_BI2")]
        [Display(Name = "飲料集金日2")]
        public string? InryoShukinBi2 { get; set; }

        [Column("KASI_SHUKIN_NENMATU")]
        [Display(Name = "菓子集金年末")]
        public string? KasiShukinNenMatu { get; set; }

        [Column("INRYO_SHUKIN_NENMATU")]
        [Display(Name = "飲料集金年末")]
        public string? InryoShukinNenMatu { get; set; }

        [Column("KASI_AZUKARI_KBN")]
        [Display(Name = "菓子預かり区分")]
        public string? KasiAzukariKbn { get; set; }

        [Column("INRYO_AZUKARI_KBN")]
        [Display(Name = "飲料預かり区分")]
        public string? InryoAzukariKbn { get; set; }

        [Column("KASI_SAITO_NENMATU")]
        [Display(Name = "菓子サイト年末")]
        public string? KasiSaitoNenMatu { get; set; }

        [Column("INRYO_SAITO_NENMATU")]
        [Display(Name = "飲料サイト年末")]
        public string? InryoSaitoNenMatu { get; set; }

        [Column("KASI_KAISHU_KBN")]
        [Display(Name = "菓子回収区分")]
        public string? KasiKaishuKbn { get; set; }

        [Column("KASI_SEISO_SHO_CD")]
        [Display(Name = "菓子清掃所CD")]
        public string? KasiSeisoShoCd { get; set; }

        [Column("KASI_SEISOTEN_CD")]
        [Display(Name = "菓子清掃店CD")]
        public string? KasiSeisotenCd { get; set; }

        [Column("INRYO_KAISHU_KBN")]
        [Display(Name = "飲料回収区分")]
        public string? InryoKaishuKbn { get; set; }

        [Column("INRYO_SEISO_SHO_CD")]
        [Display(Name = "飲料清掃所CD")]
        public string? InryoSeisoShoCd { get; set; }

        [Column("INRYO_SEISOTEN_CD")]
        [Display(Name = "飲料清掃店CD")]
        public string? InryoSeisotenCd { get; set; }

        [Column("KASI_TOKUR_TEN")]
        [Display(Name = "菓子得R店CD")]
        public string? KasiTokurTen { get; set; }

        [Column("SEIKYU_DENZAN")]
        [Display(Name = "請求電算")]
        public string? SeikyuDenzan { get; set; }

        [Column("KASI_TOKUR_SIHARAI")]
        [Display(Name = "菓子得R支払")]
        public string? KasiTokurShiharai { get; set; }

        [Column("INRYO_DAIRITEN_CD")]
        [Display(Name = "飲料代理店")]
        public string? InryoDairitenCd { get; set; }

        [Column("JUTEN_SOKUHAN")]
        [Display(Name = "重点測範")]
        public string? JutenSokuhan { get; set; }

        [Column("KASI_KECHAKU_UMU")]
        [Display(Name = "菓子結着有無")]
        public string? KasiKechakuUmu { get; set; }

        [Column("INRYO_KECHAKU_UMU")]
        [Display(Name = "飲料結着有無")]
        public string? InryoKechakuUmu { get; set; }

        [Column("SEISO_ATUKAI")]
        [Display(Name = "清掃扱い")]
        public string? SeisoAtukai { get; set; }

        [Column("KASI_DAIRITEN_SAKUHO")]
        [Display(Name = "菓子代理店作法")]
        public string? KasiDairitenSakuho { get; set; }

        [Column("RIREKI1")]
        [Display(Name = "履歴1")]
        public string? Rireki1 { get; set; }

        [Column("TANMATU1")]
        [Display(Name = "端末1")]
        public string? Tanmatu1 { get; set; }

        [Column("RIREKI2")]
        [Display(Name = "履歴2")]
        public string? Rireki2 { get; set; }

        [Column("TANMATU2")]
        [Display(Name = "端末2")]
        public string? Tanmatu2 { get; set; }

        [Column("RIREKI3")]
        [Display(Name = "履歴3")]
        public string? Rireki3 { get; set; }

        [Column("TANMATU3")]
        [Display(Name = "端末3")]
        public string? Tanmatu3 { get; set; }

        [Column("RIREKI4")]
        [Display(Name = "履歴4")]
        public string? Rireki4 { get; set; }

        [Column("TANMATU4")]
        [Display(Name = "端末4")]
        public string? Tanmatu4 { get; set; }

        [Column("RIREKI5")]
        [Display(Name = "履歴5")]
        public string? Rireki5 { get; set; }

        [Column("TANMATU5")]
        [Display(Name = "端末5")]
        public string? Tanmatu5 { get; set; }

        [Column("BL_SHO_CD")]
        [Display(Name = "ブロック所CD")]
        public string? BlShoCd { get; set; }

        [Column("BL_COURSE")]
        [Display(Name = "ブロックコース")]
        public string? BlCourse { get; set; }
    }
}
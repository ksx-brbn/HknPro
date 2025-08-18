using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "���Ӑ�}�X�^")]
    public class MTokui
    {
        [Column("KY_TOKUI_CD")]
        [Display(Name = "���Ӑ�CD")]
        public string? KyTokuiCd { get; set; }

        [Column("KY_KAISI_YMD")]
        [Display(Name = "�J�n�N����")]
        public string? KyKaisiYmd { get; set; }

        [Column("KY_SHURYO_YMD")]
        [Display(Name = "�I���N����")]
        public string? KyShuryoYmd { get; set; }

        [Column("TOKUI_NM")]
        [Display(Name = "���Ӑ於")]
        public string? TokuiNm { get; set; }

        [Column("TOKUI_KANA")]
        [Display(Name = "���Ӑ於�J�i")]
        public string? TokuiKana { get; set; }

        [Column("TOKUI_RYAKU")]
        [Display(Name = "���Ӑ旪��")]
        public string? TokuiRyaku { get; set; }

        [Column("TOKUI_RYAKU_KANA")]
        [Display(Name = "���Ӑ旪�̃J�i")]
        public string? TokuiRyakuKana { get; set; }

        [Column("KEN_NM")]
        [Display(Name = "����")]
        public string? KenNm { get; set; }

        [Column("SICHOSON_NM")]
        [Display(Name = "�s������")]
        public string? SichosonNm { get; set; }

        [Column("JUSHO_KANA")]
        [Display(Name = "�Z���J�i")]
        public string? JushoKana { get; set; }

        [Column("DAIHYO_DAIHYO_BUNRUI")]
        [Display(Name = "��\����")]
        public string? DaihyoDaihyoBunrui { get; set; }

        [Column("DAIHYO_NM")]
        [Display(Name = "��\��")]
        public string? DaihyoNm { get; set; }

        [Column("DAIHYO_BIRTHDAY")]
        [Display(Name = "��\�a����")]
        public string? DaihyoBirthday { get; set; }

        [Column("DAIHYO_TOKI")]
        [Display(Name = "��\���L����")]
        public string? DaihyoToki { get; set; }

        [Column("SICHOSON_CD")]
        [Display(Name = "�s����CD")]
        public string? SichosonCd { get; set; }

        [Column("SHUKA_SOKO_CD")]
        [Display(Name = "�o�בq��CD")]
        public string? ShukaSokoCd { get; set; }

        [Column("YUBIN_UE")]
        [Display(Name = "�X��(��)")]
        public string? YubinUe { get; set; }

        [Column("YUBIN_SITA")]
        [Display(Name = "�X��(��)")]
        public string? YubinSita { get; set; }

        [Column("TEL_NO1")]
        [Display(Name = "�d�b�ԍ�1")]
        public string? TelNo1 { get; set; }

        [Column("TEL_NO2")]
        [Display(Name = "�d�b�ԍ�2")]
        public string? TelNo2 { get; set; }

        [Column("FAX_NO1")]
        [Display(Name = "FAX1")]
        public string? FaxNo1 { get; set; }

        [Column("FAX_NO2")]
        [Display(Name = "FAX2")]
        public string? FaxNo2 { get; set; }

        [Column("MISE_BUNRUI")]
        [Display(Name = "�X����")]
        public byte? MiseBunrui { get; set; }

        [Column("BLOCK_CD")]
        [Display(Name = "�u���b�NCD")]
        public string? BlockCd { get; set; }

        [Column("CHUSI_BUNRUI")]
        [Display(Name = "���~����")]
        public string? ChusiBunrui { get; set; }

        [Column("CHUSI_JITEN")]
        [Display(Name = "���~���_")]
        public string? ChusiJiten { get; set; }

        [Column("SEIKYU_KEIRO_BUNRUI")]
        [Display(Name = "�����o�H����")]
        public string? SeikyuKeiroBunrui { get; set; }

        [Column("EIGYO_KEIRO_BUNRUI1")]
        [Display(Name = "�c�ƌo�H����1")]
        public string? EigyoKeiroBunrui1 { get; set; }

        [Column("HONSHA_BUNRUI")]
        [Display(Name = "�{�Е���")]
        public string? HonshaBunrui { get; set; }

        [Column("GROUP_HONSHA_CD")]
        [Display(Name = "�O���[�v�{��CD")]
        public string? GroupHonshaCd { get; set; }

        [Column("BUNSHA_HONSHA_CD")]
        [Display(Name = "���Ж{��CD")]
        public string? BunshaHonshaCd { get; set; }

        [Column("TOKUI_HONTEN_CD")]
        [Display(Name = "���Ӑ�{�XCD")]
        public string? TokuiHontenCd { get; set; }

        [Column("TANTO_KBN")]
        [Display(Name = "�S���敪")]
        public string? TantoKbn { get; set; }

        [Column("TORIHIKI_KBN")]
        [Display(Name = "����敪")]
        public string? TorihikiKbn { get; set; }

        [Column("TOKUKAHI_KBN")]
        [Display(Name = "���Ӑ�ۋ敪")]
        public string? TokukahiKbn { get; set; }

        [Column("KINO_BUNRUI")]
        [Display(Name = "�@�\�敪")]
        public string? KinoBunrui { get; set; }

        [Column("FORO_KBN")]
        [Display(Name = "�t�H���[�敪")]
        public string? ForoKbn { get; set; }

        [Column("MISE_RANK")]
        [Display(Name = "�X�����N")]
        public string? MiseRank { get; set; }

        [Column("REGYUTAI_MISE_KBN")]
        [Display(Name = "���M�����[�ԓX�敪")]
        public string? RegyutaiMiseKbn { get; set; }

        [Column("CHOKUTAI_MISE_KBN")]
        [Display(Name = "���ԓX�敪")]
        public string? ChokutaiMiseKbn { get; set; }

        [Column("JUCHU_KAHI_KBN")]
        [Display(Name = "�󒍉ۋ敪")]
        public string? JuchuKahiKbn { get; set; }

        [Column("JUCHU_CHOSEI_KBN")]
        [Display(Name = "�󒍒����敪")]
        public string? JuchuChoseiKbn { get; set; }

        [Column("SENDO_YOKYU_KBN")]
        [Display(Name = "�N�x�v���敪")]
        public string? SendoYokyuKbn { get; set; }

        [Column("NOHIN_JIKAN_SITEITEN")]
        [Display(Name = "�[�i���Ԏw��X")]
        public string? NohinJikanSiteiten { get; set; }

        [Column("NOHIN_SITEI_KAISI")]
        [Display(Name = "�[�i�w��J�n")]
        public string? NohinSiteiKaisi { get; set; }

        [Column("NOHIN_SITEI_SHURYO")]
        [Display(Name = "�[�i�w��I��")]
        public string? NohinSiteiShuryo { get; set; }

        [Column("HOREI_SETUBI_UMU")]
        [Display(Name = "�@�ߐݔ��L��")]
        public string? HoreiSetubiUmu { get; set; }

        [Column("TEIKYUBI")]
        [Display(Name = "��x��")]
        public string? Teikyubi { get; set; }

        [Column("FORO_BL_CD")]
        [Display(Name = "�t�H���[�u���b�NCD")]
        public string? ForoBlCd { get; set; }

        [Column("NENSHO")]
        [Display(Name = "�N��")]
        public int? Nensho { get; set; }

        [Column("SENDENPYO_KBN")]
        [Display(Name = "��`�[�敪")]
        public string? SendenpyoKbn { get; set; }

        [Column("KASI_VAN_CD")]
        [Display(Name = "�َqVANCD")]
        public string? KasiVanCd { get; set; }

        [Column("KASI_SHODAN_KATAGAKI")]
        [Display(Name = "�َq���k����")]
        public string? KasiShodanKatagaki { get; set; }

        [Column("KASI_SHODAN_NM")]
        [Display(Name = "�َq���k��")]
        public string? KasiShodanNm { get; set; }

        [Column("KASI_SHODAN_BIRTHDAY")]
        [Display(Name = "�َq���k�a����")]
        public string? KasiShodanBirthday { get; set; }

        [Column("KASI_SHODAN_TOKI")]
        [Display(Name = "�َq���k���L����")]
        public string? KasiShodanToki { get; set; }

        [Column("KASI_SHOJO_KATAGAKI")]
        [Display(Name = "�َq���󌨏�")]
        public string? KasiShojoKatagaki { get; set; }

        [Column("KASI_SHOJO_NM")]
        [Display(Name = "�َq����")]
        public string? KasiShojoNm { get; set; }

        [Column("KASI_SHOJO_BIRTHDAY")]
        [Display(Name = "�َq����a����")]
        public string? KasiShojoBirthday { get; set; }

        [Column("KASI_SHOJO_TOKI")]
        [Display(Name = "�َq������L����")]
        public string? KasiShojoToki { get; set; }

        [Column("KASI_NENURI")]
        [Display(Name = "�َq�N��")]
        public int? KasiNenuri { get; set; }

        [Column("KASI_URITAN_SHO_CD")]
        [Display(Name = "�َq���S����CD")]
        public string? KasiUritanShoCd { get; set; }

        [Column("KASI_URITAN_SHA_CD")]
        [Display(Name = "�َq���S����CD")]
        public string? KasiUritanShaCd { get; set; }

        [Column("KASI_FO_SHO_CD")]
        [Display(Name = "�َq�t�H���[��CD")]
        public string? KasiFoShoCd { get; set; }

        [Column("KASI_FO_SHA_CD")]
        [Display(Name = "�َq�t�H���[��CD")]
        public string? KasiFoShaCd { get; set; }

        [Column("KASI_CHOAI_CD")]
        [Display(Name = "�َq����CD")]
        public string? KasiChoaiCd { get; set; }

        [Column("KASI_2CHOAI_CD")]
        [Display(Name = "�َq2����CD")]
        public string? Kasi2ChoaiCd { get; set; }

        [Column("KASI_3CHOAI_CD")]
        [Display(Name = "�َq3����CD")]
        public string? Kasi3ChoaiCd { get; set; }

        [Column("KASI_ETC_CHOAI1")]
        [Display(Name = "�َqETC����1")]
        public string? KasiEtcChoai1 { get; set; }

        [Column("KASI_ETC_CHOAI2")]
        [Display(Name = "�َqETC����2")]
        public string? KasiEtcChoai2 { get; set; }

        [Column("KASI_ETC_CHOAI3")]
        [Display(Name = "�َqETC����3")]
        public string? KasiEtcChoai3 { get; set; }

        [Column("KASI_KAISI_YMD")]
        [Display(Name = "�َq�J�n�N����")]
        public string? KasiKaisiYmd { get; set; }

        [Column("KASI_CHUSI_YMD")]
        [Display(Name = "�َq�I���N����")]
        public string? KasiChusiYmd { get; set; }

        [Column("KASI_SAISHU_HOMON_YMD")]
        [Display(Name = "�َq�ŏI�K��N����")]
        public string? KasiSaishuHomonYmd { get; set; }

        [Column("INRYO_SHODAN_KATAGAKI")]
        [Display(Name = "�������k����")]
        public string? InryoShodanKatagaki { get; set; }

        [Column("INRYO_SHODAN_NM")]
        [Display(Name = "�������k��")]
        public string? InryoShodanNm { get; set; }

        [Column("INRYO_SHODAN_BIRTHDAY")]
        [Display(Name = "�������k�a����")]
        public string? InryoShodanBirthday { get; set; }

        [Column("INRYO_SHODAN_TOKI")]
        [Display(Name = "�������k���L����")]
        public string? InryoShodanToki { get; set; }

        [Column("INRYO_SHOJO_KATAGAKI")]
        [Display(Name = "�������󌨏�")]
        public string? InryoShojoKatagaki { get; set; }

        [Column("INRYO_SHOJO_NM")]
        [Display(Name = "��������")]
        public string? InryoShojoNm { get; set; }

        [Column("INRYO_SHOJO_BIRTHDAY")]
        [Display(Name = "��������a����")]
        public string? InryoShojoBirthday { get; set; }

        [Column("INRYO_SHOJO_TOKI")]
        [Display(Name = "����������L����")]
        public string? InryoShojoToki { get; set; }

        [Column("INRYO_NENURI")]
        [Display(Name = "�����N��")]
        public int? InryoNenuri { get; set; }

        [Column("INRYO_URITAN_SHO_CD")]
        [Display(Name = "�������S����CD")]
        public string? InryoUritanShoCd { get; set; }

        [Column("INRYO_URITAN_SHA_CD")]
        [Display(Name = "�������S����CD")]
        public string? InryoUritanShaCd { get; set; }

        [Column("INRYO_FO_SHO_CD")]
        [Display(Name = "�����t�H���[��CD")]
        public string? InryoFoShoCd { get; set; }

        [Column("INRYO_FO_SHA_CD")]
        [Display(Name = "�����t�H���[��CD")]
        public string? InryoFoShaCd { get; set; }

        [Column("INRYO_CHOAI_CD")]
        [Display(Name = "��������CD")]
        public string? InryoChoaiCd { get; set; }

        [Column("INRYO_2CHOAI_CD")]
        [Display(Name = "����2����CD")]
        public string? Inryo2ChoaiCd { get; set; }

        [Column("INRYO_3CHOAI_CD")]
        [Display(Name = "����3����CD")]
        public string? Inryo3ChoaiCd { get; set; }

        [Column("INRYO_ETC_CHOAI1")]
        [Display(Name = "����ETC����1")]
        public string? InryoEtcChoai1 { get; set; }

        [Column("INRYO_ETC_CHOAI2")]
        [Display(Name = "����ETC����2")]
        public string? InryoEtcChoai2 { get; set; }

        [Column("INRYO_ETC_CHOAI3")]
        [Display(Name = "����ETC����3")]
        public string? InryoEtcChoai3 { get; set; }

        [Column("INRYO_KAISI_YMD")]
        [Display(Name = "�����J�n�N����")]
        public string? InryoKaisiYmd { get; set; }

        [Column("INRYO_CHUSI_YMD")]
        [Display(Name = "�����I���N����")]
        public string? InryoChusiYmd { get; set; }

        [Column("INRYO_SAISHU_HOMON_YMD")]
        [Display(Name = "�����ŏI�N����")]
        public string? InryoSaishuHomonYmd { get; set; }

        [Column("DM_KBN")]
        [Display(Name = "DM�敪")]
        public string? DmKbn { get; set; }

        [Column("JURYO_UMU")]
        [Display(Name = "�d�ʗL��")]
        public string? JuryoUmu { get; set; }

        [Column("SENYO_DENPYO_CD")]
        [Display(Name = "��p�`�[CD")]
        public string? SenyoDenpyoCd { get; set; }

        [Column("KASI_RIKEISANHON_CD")]
        [Display(Name = "�َq���v�Z�{�XCD")]
        public string? KasiRikeisanhonCd { get; set; }

        [Column("KASI_DAIRITEN_CD")]
        [Display(Name = "�َq�㗝�XCD")]
        public string? KasiDairitenCd { get; set; }

        [Column("KASI_KAISHU_TANTOSHO_CD")]
        [Display(Name = "�َq����S����CD")]
        public string? KasiKaishuTantoshoCd { get; set; }

        [Column("KASI_KAISHU_TANTOSHA_CD")]
        [Display(Name = "�َq����S����CD")]
        public string? KasiKaishuTantoshaCd { get; set; }

        [Column("KASI_SEIKYU_TANI_CD")]
        [Display(Name = "�َq�����P��CD")]
        public string? KasiSeikyuTaniCd { get; set; }

        [Column("KASI_SEIKYU_SIMEBI")]
        [Display(Name = "�َq��������")]
        public string? KasiSeikyuSimebi { get; set; }

        [Column("KASI_SHUKIN_BI")]
        [Display(Name = "�َq�W����")]
        public string? KasiShukinBi { get; set; }

        [Column("KASI_KAISHU_SITE")]
        [Display(Name = "�َq����w���")]
        public string? KasiKaishuSite { get; set; }

        [Column("INRYO_SEIKYU_TANI_CD")]
        [Display(Name = "���������P��CD")]
        public string? InryoSeikyuTaniCd { get; set; }

        [Column("INRYO_KAISHU_TANTOSHO_CD")]
        [Display(Name = "��������S����CD")]
        public string? InryoKaishuTantoshoCd { get; set; }

        [Column("INRYO_KAISHU_TANTOSHA_CD")]
        [Display(Name = "��������S����CD")]
        public string? InryoKaishuTantoshaCd { get; set; }

        [Column("INRYO_SEIKYU_SIMEBI")]
        [Display(Name = "������������")]
        public string? InryoSeikyuSimebi { get; set; }

        [Column("INRYO_SHUKIN_BI")]
        [Display(Name = "�����W����")]
        public string? InryoShukinBi { get; set; }

        [Column("INRYO_KAISHU_SITE")]
        [Display(Name = "��������w���")]
        public string? InryoKaishuSite { get; set; }

        [Column("TOROKU_YMD")]
        [Display(Name = "�o�^�N����")]
        public string? TorokuYmd { get; set; }

        [Column("TOROKU_TIME")]
        [Display(Name = "�o�^����")]
        public string? TorokuTime { get; set; }

        [Column("DELETE_FLG")]
        [Display(Name = "�폜�t���O")]
        public string? DeleteFlg { get; set; }

        [Column("HAISIN_FLG")]
        [Display(Name = "�z�M�t���O")]
        public string? HaisinFlg { get; set; }

        [Column("HAISIN_YMD")]
        [Display(Name = "�z�M�N����")]
        public string? HaisinYmd { get; set; }

        [Column("KASI_SEIKYU_SIMEBI2")]
        [Display(Name = "�َq��������2")]
        public string? KasiSeikyuSimebi2 { get; set; }

        [Column("INRYO_SEIKYU_SIMEBI2")]
        [Display(Name = "������������2")]
        public string? InryoSeikyuSimebi2 { get; set; }

        [Column("KASI_SIMEBI_NENMATU")]
        [Display(Name = "�َq�����N��")]
        public string? KasiSimebiNenMatu { get; set; }

        [Column("INRYO_SIMEBI_NENMATU")]
        [Display(Name = "���������N��")]
        public string? InryoSimebiNenMatu { get; set; }

        [Column("KASI_SHUKIN_BI2")]
        [Display(Name = "�َq�W����2")]
        public string? KasiShukinBi2 { get; set; }

        [Column("INRYO_SHUKIN_BI2")]
        [Display(Name = "�����W����2")]
        public string? InryoShukinBi2 { get; set; }

        [Column("KASI_SHUKIN_NENMATU")]
        [Display(Name = "�َq�W���N��")]
        public string? KasiShukinNenMatu { get; set; }

        [Column("INRYO_SHUKIN_NENMATU")]
        [Display(Name = "�����W���N��")]
        public string? InryoShukinNenMatu { get; set; }

        [Column("KASI_AZUKARI_KBN")]
        [Display(Name = "�َq�a����敪")]
        public string? KasiAzukariKbn { get; set; }

        [Column("INRYO_AZUKARI_KBN")]
        [Display(Name = "�����a����敪")]
        public string? InryoAzukariKbn { get; set; }

        [Column("KASI_SAITO_NENMATU")]
        [Display(Name = "�َq�T�C�g�N��")]
        public string? KasiSaitoNenMatu { get; set; }

        [Column("INRYO_SAITO_NENMATU")]
        [Display(Name = "�����T�C�g�N��")]
        public string? InryoSaitoNenMatu { get; set; }

        [Column("KASI_KAISHU_KBN")]
        [Display(Name = "�َq����敪")]
        public string? KasiKaishuKbn { get; set; }

        [Column("KASI_SEISO_SHO_CD")]
        [Display(Name = "�َq���|��CD")]
        public string? KasiSeisoShoCd { get; set; }

        [Column("KASI_SEISOTEN_CD")]
        [Display(Name = "�َq���|�XCD")]
        public string? KasiSeisotenCd { get; set; }

        [Column("INRYO_KAISHU_KBN")]
        [Display(Name = "��������敪")]
        public string? InryoKaishuKbn { get; set; }

        [Column("INRYO_SEISO_SHO_CD")]
        [Display(Name = "�������|��CD")]
        public string? InryoSeisoShoCd { get; set; }

        [Column("INRYO_SEISOTEN_CD")]
        [Display(Name = "�������|�XCD")]
        public string? InryoSeisotenCd { get; set; }

        [Column("KASI_TOKUR_TEN")]
        [Display(Name = "�َq��R�XCD")]
        public string? KasiTokurTen { get; set; }

        [Column("SEIKYU_DENZAN")]
        [Display(Name = "�����d�Z")]
        public string? SeikyuDenzan { get; set; }

        [Column("KASI_TOKUR_SIHARAI")]
        [Display(Name = "�َq��R�x��")]
        public string? KasiTokurShiharai { get; set; }

        [Column("INRYO_DAIRITEN_CD")]
        [Display(Name = "�����㗝�X")]
        public string? InryoDairitenCd { get; set; }

        [Column("JUTEN_SOKUHAN")]
        [Display(Name = "�d�_����")]
        public string? JutenSokuhan { get; set; }

        [Column("KASI_KECHAKU_UMU")]
        [Display(Name = "�َq�����L��")]
        public string? KasiKechakuUmu { get; set; }

        [Column("INRYO_KECHAKU_UMU")]
        [Display(Name = "���������L��")]
        public string? InryoKechakuUmu { get; set; }

        [Column("SEISO_ATUKAI")]
        [Display(Name = "���|����")]
        public string? SeisoAtukai { get; set; }

        [Column("KASI_DAIRITEN_SAKUHO")]
        [Display(Name = "�َq�㗝�X��@")]
        public string? KasiDairitenSakuho { get; set; }

        [Column("RIREKI1")]
        [Display(Name = "����1")]
        public string? Rireki1 { get; set; }

        [Column("TANMATU1")]
        [Display(Name = "�[��1")]
        public string? Tanmatu1 { get; set; }

        [Column("RIREKI2")]
        [Display(Name = "����2")]
        public string? Rireki2 { get; set; }

        [Column("TANMATU2")]
        [Display(Name = "�[��2")]
        public string? Tanmatu2 { get; set; }

        [Column("RIREKI3")]
        [Display(Name = "����3")]
        public string? Rireki3 { get; set; }

        [Column("TANMATU3")]
        [Display(Name = "�[��3")]
        public string? Tanmatu3 { get; set; }

        [Column("RIREKI4")]
        [Display(Name = "����4")]
        public string? Rireki4 { get; set; }

        [Column("TANMATU4")]
        [Display(Name = "�[��4")]
        public string? Tanmatu4 { get; set; }

        [Column("RIREKI5")]
        [Display(Name = "����5")]
        public string? Rireki5 { get; set; }

        [Column("TANMATU5")]
        [Display(Name = "�[��5")]
        public string? Tanmatu5 { get; set; }

        [Column("BL_SHO_CD")]
        [Display(Name = "�u���b�N��CD")]
        public string? BlShoCd { get; set; }

        [Column("BL_COURSE")]
        [Display(Name = "�u���b�N�R�[�X")]
        public string? BlCourse { get; set; }
    }
}
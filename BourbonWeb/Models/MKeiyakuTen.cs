using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�_��X�}�X�^")]
    public class MKeiyakuTen
    {
        [Column("KEIYAKU_TEN_TOKUI_CD")]
        [Display(Name = "�_��X���Ӑ�R�[�h")]
        public string? KeiyakuTenTokuiCd { get; set; }

        [Column("KEIYAKU_KAISI_YM")]
        [Display(Name = "�_��J�n�N��")]
        public string? KeiyakuKaisiYm { get; set; }

        [Column("KEIYAKU_SHURYO_YM")]
        [Display(Name = "�_��I���N��")]
        public string? KeiyakuShuryoYm { get; set; }

        [Column("ZENNEN_DOKI_KEIYAKU")]
        [Display(Name = "�O�N�����_��")]
        public string? ZennenDokiKeiyaku { get; set; }

        [Column("GYOTAI_KBN")]
        [Display(Name = "�Ƒԋ敪")]
        public string? GyotaiKbn { get; set; }

        [Column("MISE_KBN")]
        [Display(Name = "�X�敪")]
        public string? MiseKbn { get; set; }

        [Column("FORO_KBN")]
        [Display(Name = "�t�H���[�敪")]
        public string? ForoKbn { get; set; }

        [Column("TOKUI_NM")]
        [Display(Name = "���Ӑ於")]
        public string? TokuiNm { get; set; }

        [Column("TOKUI_KANA")]
        [Display(Name = "���Ӑ於�J�i")]
        public string? TokuiKana { get; set; }

        [Column("YUBIN")]
        [Display(Name = "�X�֔ԍ�")]
        public string? Yubin { get; set; }

        [Column("KEN_CD")]
        [Display(Name = "���R�[�h")]
        public string? KenCd { get; set; }

        [Column("JUSHO")]
        [Display(Name = "�Z��")]
        public string? Jusho { get; set; }

        [Column("TEL_NO")]
        [Display(Name = "�d�b�ԍ�")]
        public string? TelNo { get; set; }

        [Column("FAX_NO")]
        [Display(Name = "�e�`�w�ԍ�")]
        public string? FaxNo { get; set; }

        [Column("HOME_PAGE")]
        [Display(Name = "�z�[���y�[�W")]
        public string? HomePage { get; set; }

        [Column("SHACHO_NM")]
        [Display(Name = "�В���")]
        public string? ShachoNm { get; set; }

        [Column("TENPO_SU")]
        [Display(Name = "�X�ܐ�")]
        public int? TenpoSu { get; set; }

        [Column("SAKUNEN_HI_ZOGEN_TENSU")]
        [Display(Name = "��N�䑝���X��")]
        public int? SakunenHiZogenTensu { get; set; }

        [Column("NENSHO")]
        [Display(Name = "�N��")]
        public decimal? Nensho { get; set; }

        [Column("NENSHO_SINCHO_RATE")]
        [Display(Name = "�N���L����")]
        public decimal? NenshoSinchoRate { get; set; }

        [Column("KASI_NENSHO")]
        [Display(Name = "�َq�N��")]
        public decimal? KasiNensho { get; set; }

        [Column("KASI_NENSHO_SINCHO_RATE")]
        [Display(Name = "�َq�N���L����")]
        public decimal? KasiNenshoSinchoRate { get; set; }

        [Column("SHOKUHIN_NENSHO")]
        [Display(Name = "�H�i�N��")]
        public decimal? ShokuhinNensho { get; set; }

        [Column("SHOKUHIN_NENSHO_SINCHO_RATE")]
        [Display(Name = "�H�i�N���L����")]
        public decimal? ShokuhinNenshoSinchoRate { get; set; }

        [Column("NENSHO_NENDO")]
        [Display(Name = "�N���N�x")]
        public string? NenshoNendo { get; set; }

        [Column("KAMEI_DANTAI_NM")]
        [Display(Name = "�����c�̖�")]
        public string? KameiDantaiNm { get; set; }

        [Column("KAMEI_KYODO_SIIRE_KIKO")]
        [Display(Name = "���������d���@�\")]
        public string? KameiKyodoSiireKiko { get; set; }

        [Column("SHOKUHIN_BUCHO")]
        [Display(Name = "�H�i����")]
        public string? ShokuhinBucho { get; set; }

        [Column("KASI_TANTO1")]
        [Display(Name = "�َq�S���P")]
        public string? KasiTanto1 { get; set; }

        [Column("KASI_TANTO2")]
        [Display(Name = "�َq�S���Q")]
        public string? KasiTanto2 { get; set; }

        [Column("SHOKUHIN_TANTO1")]
        [Display(Name = "�H�i�S���P")]
        public string? ShokuhinTanto1 { get; set; }

        [Column("SHOKUHIN_TANTO2")]
        [Display(Name = "�H�i�S���Q")]
        public string? ShokuhinTanto2 { get; set; }

        [Column("KASI_CHOAI_CD1")]
        [Display(Name = "�َq�����R�[�h�P")]
        public string? KasiChoaiCd1 { get; set; }

        [Column("KASI_CHOAI_CD2")]
        [Display(Name = "�َq�����R�[�h�Q")]
        public string? KasiChoaiCd2 { get; set; }

        [Column("KASI_CHOAI_CD3")]
        [Display(Name = "�َq�����R�[�h�R")]
        public string? KasiChoaiCd3 { get; set; }

        [Column("SHOKUHIN_CHOAI_CD1")]
        [Display(Name = "�H�i�����R�[�h�P")]
        public string? ShokuhinChoaiCd1 { get; set; }

        [Column("SHOKUHIN_CHOAI_CD2")]
        [Display(Name = "�H�i�����R�[�h�Q")]
        public string? ShokuhinChoaiCd2 { get; set; }

        [Column("KASI_CHOAI1")]
        [Display(Name = "�َq�����P")]
        public string? KasiChoai1 { get; set; }

        [Column("KASI_CHOAI2")]
        [Display(Name = "�َq�����Q")]
        public string? KasiChoai2 { get; set; }

        [Column("KASI_CHOAI3")]
        [Display(Name = "�َq�����R")]
        public string? KasiChoai3 { get; set; }

        [Column("SHOKUHIN_CHOAI1")]
        [Display(Name = "�H�i�����P")]
        public string? ShokuhinChoai1 { get; set; }

        [Column("SHOKUHIN_CHOAI2")]
        [Display(Name = "�H�i�����Q")]
        public string? ShokuhinChoai2 { get; set; }

        [Column("MTOKUI_CD")]
        [Display(Name = "MTOKUI�R�[�h")]
        public string? MtokuiCd { get; set; }

        [Column("TANTO_SHO_CD")]
        [Display(Name = "�S�����R�[�h")]
        public string? TantoShoCd { get; set; }

        [Column("TANTO_SHA_CD")]
        [Display(Name = "�S���Z�[���X�R�[�h")]
        public string? TantoShaCd { get; set; }

        [Column("TANTO_KAISI")]
        [Display(Name = "�S���J�n")]
        public string? TantoKaisi { get; set; }

        [Column("ZEN_TANTO")]
        [Display(Name = "�O�C�S��")]
        public string? ZenTanto { get; set; }

        [Column("ZEN_TANTO_KAISI")]
        [Display(Name = "�O�C�S���J�n")]
        public string? ZenTantoKaisi { get; set; }

        [Column("ZENZEN_TANTO")]
        [Display(Name = "�O�O�C�S��")]
        public string? ZenzenTanto { get; set; }

        [Column("ZENZEN_TANTO_KAISI")]
        [Display(Name = "�O�O�C�S���J�n")]
        public string? ZenzenTantoKaisi { get; set; }

        [Column("JUNI1")]
        [Display(Name = "����1")]
        public string? Juni1 { get; set; }

        [Column("JUNI2")]
        [Display(Name = "����2")]
        public string? Juni2 { get; set; }

        [Column("JUNI3")]
        [Display(Name = "����3")]
        public string? Juni3 { get; set; }

        [Column("JUNI4")]
        [Display(Name = "����4")]
        public string? Juni4 { get; set; }

        [Column("JUNI5")]
        [Display(Name = "����5")]
        public string? Juni5 { get; set; }

        [Column("JUNI6")]
        [Display(Name = "����6")]
        public string? Juni6 { get; set; }

        [Column("JUNI7")]
        [Display(Name = "����7")]
        public string? Juni7 { get; set; }

        [Column("JUNI8")]
        [Display(Name = "����8")]
        public string? Juni8 { get; set; }

        [Column("JUNI9")]
        [Display(Name = "����9")]
        public string? Juni9 { get; set; }

        [Column("JUNI10")]
        [Display(Name = "����10")]
        public string? Juni10 { get; set; }

        [Column("SHARE1")]
        [Display(Name = "�V�F�A�[1")]
        public string? Share1 { get; set; }

        [Column("SHARE2")]
        [Display(Name = "�V�F�A�[2")]
        public string? Share2 { get; set; }

        [Column("SHARE3")]
        [Display(Name = "�V�F�A�[3")]
        public string? Share3 { get; set; }

        [Column("SHARE4")]
        [Display(Name = "�V�F�A�[4")]
        public string? Share4 { get; set; }

        [Column("SHARE5")]
        [Display(Name = "�V�F�A�[5")]
        public string? Share5 { get; set; }

        [Column("SHARE6")]
        [Display(Name = "�V�F�A�[6")]
        public string? Share6 { get; set; }

        [Column("SHARE7")]
        [Display(Name = "�V�F�A�[7")]
        public string? Share7 { get; set; }

        [Column("SHARE8")]
        [Display(Name = "�V�F�A�[8")]
        public string? Share8 { get; set; }

        [Column("SHARE9")]
        [Display(Name = "�V�F�A�[9")]
        public string? Share9 { get; set; }

        [Column("SHARE10")]
        [Display(Name = "�V�F�A�[10")]
        public string? Share10 { get; set; }

        [Column("MOKUHYO1")]
        [Display(Name = "�ڕW1")]
        public decimal? Mokuhyo1 { get; set; }

        [Column("REBATE1")]
        [Display(Name = "���x1")]
        public decimal? Rebate1 { get; set; }

        [Column("MOKUHYO2")]
        [Display(Name = "�ڕW2")]
        public decimal? Mokuhyo2 { get; set; }

        [Column("REBATE2")]
        [Display(Name = "���x2")]
        public decimal? Rebate2 { get; set; }

        [Column("MOKUHYO3")]
        [Display(Name = "�ڕW3")]
        public decimal? Mokuhyo3 { get; set; }

        [Column("REBATE3")]
        [Display(Name = "���x3")]
        public decimal? Rebate3 { get; set; }

        [Column("MOKUHYO4")]
        [Display(Name = "�ڕW4")]
        public decimal? Mokuhyo4 { get; set; }

        [Column("REBATE4")]
        [Display(Name = "���x4")]
        public decimal? Rebate4 { get; set; }

        [Column("MOKUHYO5")]
        [Display(Name = "�ڕW5")]
        public decimal? Mokuhyo5 { get; set; }

        [Column("REBATE5")]
        [Display(Name = "���x5")]
        public decimal? Rebate5 { get; set; }

        [Column("MOKUHYO6")]
        [Display(Name = "�ڕW6")]
        public decimal? Mokuhyo6 { get; set; }

        [Column("REBATE6")]
        [Display(Name = "���x6")]
        public decimal? Rebate6 { get; set; }

        [Column("MOKUHYO7")]
        [Display(Name = "�ڕW7")]
        public decimal? Mokuhyo7 { get; set; }

        [Column("REBATE7")]
        [Display(Name = "���x7")]
        public decimal? Rebate7 { get; set; }

        [Column("MOKUHYO8")]
        [Display(Name = "�ڕW8")]
        public decimal? Mokuhyo8 { get; set; }

        [Column("REBATE8")]
        [Display(Name = "���x8")]
        public decimal? Rebate8 { get; set; }

        [Column("MOKUHYO9")]
        [Display(Name = "�ڕW9")]
        public decimal? Mokuhyo9 { get; set; }

        [Column("REBATE9")]
        [Display(Name = "���x9")]
        public decimal? Rebate9 { get; set; }

        [Column("KEIYAKU_JOHO_HYOJI")]
        [Display(Name = "�_����\��")]
        public string? KeiyakuJohoHyoji { get; set; }

        [Column("SANSHO_KEIYAKU_CD")]
        [Display(Name = "�Q�ƌ_��X�R�[�h")]
        public string? SanshoKeiyakuCd { get; set; }

        [Column("KOSIN_SHA")]
        [Display(Name = "�X�V��")]
        public string? KosinSha { get; set; }

        [Column("TOROKU_YMD")]
        [Display(Name = "�X�V��")]
        public string? TorokuYmd { get; set; }

        [Column("TOROKU_TIME")]
        [Display(Name = "�X�V����")]
        public string? TorokuTime { get; set; }

        [Column("DELETE_FLG")]
        [Display(Name = "�폜�t���O")]
        public string? DeleteFlg { get; set; }

        [Column("KOSIN_TANMATU")]
        [Display(Name = "�X�V�[��")]
        public string? KosinTanmatu { get; set; }

        [Column("SIN_SEIHIN_KANRI")]
        [Display(Name = "�V���i�Ǘ�")]
        public string? SinSeihinKanri { get; set; }

        [Column("ETC_KANRI1")]
        [Display(Name = "���̑��Ǘ�1")]
        public string? EtcKanri1 { get; set; }

        [Column("ETC_KANRI2")]
        [Display(Name = "���̑��Ǘ�2")]
        public string? EtcKanri2 { get; set; }

        [Column("URIAGE1")]
        [Display(Name = "����1")]
        public string? Uriage1 { get; set; }

        [Column("URIAGE2")]
        [Display(Name = "����2")]
        public string? Uriage2 { get; set; }

        [Column("URIAGE3")]
        [Display(Name = "����3")]
        public string? Uriage3 { get; set; }

        [Column("URIAGE4")]
        [Display(Name = "����4")]
        public string? Uriage4 { get; set; }

        [Column("URIAGE5")]
        [Display(Name = "����5")]
        public string? Uriage5 { get; set; }

        [Column("URIAGE6")]
        [Display(Name = "����6")]
        public string? Uriage6 { get; set; }

        [Column("URIAGE7")]
        [Display(Name = "����7")]
        public string? Uriage7 { get; set; }

        [Column("URIAGE8")]
        [Display(Name = "����8")]
        public string? Uriage8 { get; set; }

        [Column("URIAGE9")]
        [Display(Name = "����9")]
        public string? Uriage9 { get; set; }

        [Column("URIAGE10")]
        [Display(Name = "����10")]
        public string? Uriage10 { get; set; }

        [Column("AREA_NM1")]
        [Display(Name = "�G���A��1")]
        public string? AreaNm1 { get; set; }

        [Column("AREA_NM2")]
        [Display(Name = "�G���A��2")]
        public string? AreaNm2 { get; set; }

        [Column("AREA_NM3")]
        [Display(Name = "�G���A��3")]
        public string? AreaNm3 { get; set; }

        [Column("AREA_NM4")]
        [Display(Name = "�G���A��4")]
        public string? AreaNm4 { get; set; }

        [Column("AREA_NM5")]
        [Display(Name = "�G���A��5")]
        public string? AreaNm5 { get; set; }

        [Column("AREA_NM6")]
        [Display(Name = "�G���A��6")]
        public string? AreaNm6 { get; set; }

        [Column("AREA_NM7")]
        [Display(Name = "�G���A��7")]
        public string? AreaNm7 { get; set; }

        [Column("AREA_NM8")]
        [Display(Name = "�G���A��8")]
        public string? AreaNm8 { get; set; }

        [Column("AREA_NM9")]
        [Display(Name = "�G���A��9")]
        public string? AreaNm9 { get; set; }

        [Column("AREA_NM10")]
        [Display(Name = "�G���A��10")]
        public string? AreaNm10 { get; set; }

        [Column("AREA_TEN_SU1")]
        [Display(Name = "�G���A�X��1")]
        public string? AreaTenSu1 { get; set; }

        [Column("AREA_TEN_SU2")]
        [Display(Name = "�G���A�X��2")]
        public string? AreaTenSu2 { get; set; }

        [Column("AREA_TEN_SU3")]
        [Display(Name = "�G���A�X��3")]
        public string? AreaTenSu3 { get; set; }

        [Column("AREA_TEN_SU4")]
        [Display(Name = "�G���A�X��4")]
        public string? AreaTenSu4 { get; set; }

        [Column("AREA_TEN_SU5")]
        [Display(Name = "�G���A�X��5")]
        public string? AreaTenSu5 { get; set; }

        [Column("AREA_TEN_SU6")]
        [Display(Name = "�G���A�X��6")]
        public string? AreaTenSu6 { get; set; }

        [Column("AREA_TEN_SU7")]
        [Display(Name = "�G���A�X��7")]
        public string? AreaTenSu7 { get; set; }

        [Column("AREA_TEN_SU8")]
        [Display(Name = "�G���A�X��8")]
        public string? AreaTenSu8 { get; set; }

        [Column("AREA_TEN_SU9")]
        [Display(Name = "�G���A�X��9")]
        public string? AreaTenSu9 { get; set; }

        [Column("AREA_TEN_SU10")]
        [Display(Name = "�G���A�X��10")]
        public string? AreaTenSu10 { get; set; }

        [Column("KIBOBETU_GMS")]
        [Display(Name = "�K�͕�_GMS")]
        public string? KibobetuGms { get; set; }

        [Column("KIBOBETU_SM")]
        [Display(Name = "�K�͕�_SM")]
        public string? KibobetuSm { get; set; }

        [Column("KIBOBETU_DS")]
        [Display(Name = "�K�͕�_DS")]
        public string? KibobetuDs { get; set; }

        [Column("KIBOBETU_KOKYU")]
        [Display(Name = "�K�͕�_����")]
        public string? KibobetuKokyu { get; set; }

        [Column("KIBOBETU_ETC1")]
        [Display(Name = "�K�͕�_��1")]
        public string? KibobetuEtc1 { get; set; }

        [Column("KIBOBETU_ETC2")]
        [Display(Name = "�K�͕�_��2")]
        public string? KibobetuEtc2 { get; set; }

        [Column("PB_ATUKAI")]
        [Display(Name = "PB��")]
        public string? PbAtukai { get; set; }

        [Column("PB_KASI_ZENTAI")]
        [Display(Name = "PB�َq�S��")]
        public string? PbKasiZentai { get; set; }

        [Column("PB_SHOKUHIN_ZENTAI")]
        [Display(Name = "PB�H�i�S��")]
        public string? PbShokuhinZentai { get; set; }

        [Column("PB_SHOHIN1")]
        [Display(Name = "PB���i1")]
        public string? PbShohin1 { get; set; }

        [Column("PB_SHOHIN2")]
        [Display(Name = "PB���i2")]
        public string? PbShohin2 { get; set; }

        [Column("PB_SHOHIN3")]
        [Display(Name = "PB���i3")]
        public string? PbShohin3 { get; set; }

        [Column("MODEL_TENPO_NM")]
        [Display(Name = "���f��_�X�ܖ�")]
        public string? ModelTenpoNm { get; set; }

        [Column("MODEL_YUBIN")]
        [Display(Name = "���f��_�X��")]
        public string? ModelYubin { get; set; }

        [Column("MODEL_KEN_NM")]
        [Display(Name = "���f��_����")]
        public string? ModelKenNm { get; set; }

        [Column("MODEL_JUSHO")]
        [Display(Name = "���f��_�Z��")]
        public string? ModelJusho { get; set; }

        [Column("MODEL_TEL")]
        [Display(Name = "���f��_TEL")]
        public string? ModelTel { get; set; }

        [Column("MODEL_FAX")]
        [Display(Name = "���f��_FAX")]
        public string? ModelFax { get; set; }

        [Column("MODEL_URIBA_MENSEKI")]
        [Display(Name = "���f��_����ʐ�")]
        public string? ModelUribaMenseki { get; set; }

        [Column("MODEL_REGI_DAISU")]
        [Display(Name = "���f��_���W�䐔")]
        public string? ModelRegiDaisu { get; set; }

        [Column("MODEL_NYUTEN_KYAKUSU")]
        [Display(Name = "���f��_���X�q��")]
        public string? ModelNyutenKyakusu { get; set; }

        [Column("MODEL_KASI_HONSU")]
        [Display(Name = "���f��_�َq�{��")]
        public string? ModelKasiHonsu { get; set; }

        [Column("MODEL_KASI_DANSU")]
        [Display(Name = "���f��_�َq�i��")]
        public string? ModelKasiDansu { get; set; }

        [Column("MODEL_SHAKUSU")]
        [Display(Name = "���f��_�ڐ�")]
        public string? ModelShakusu { get; set; }

        [Column("MODEL_ZENTAI_KASI_TEI_ITEM")]
        [Display(Name = "���f��_�S�َ̉q��ԃA�C�e��")]
        public string? ModelZentaiKasiTeiItem { get; set; }

        [Column("MODEL_ZENTAI_KASI_TEI_FACE")]
        [Display(Name = "���f��_�S�َ̉q��ԃt�F�[�X")]
        public string? ModelZentaiKasiTeiFace { get; set; }

        [Column("MODEL_JISHA_KASI_TEI_ITEM")]
        [Display(Name = "���f��_���Љَq��ԃA�C�e��")]
        public string? ModelJishaKasiTeiItem { get; set; }

        [Column("MODEL_JISHA_KASI_TEI_FACE")]
        [Display(Name = "���f��_���Љَq��ԃt�F�[�X")]
        public string? ModelJishaKasiTeiFace { get; set; }

        [Column("MODEL_KOSIN_TUKI")]
        [Display(Name = "���f��_�X�V��")]
        public string? ModelKosinTuki { get; set; }

        [Column("TOKUI_OYA_CD")]
        [Display(Name = "���Ӑ�eCD")]
        public string? TokuiOyaCd { get; set; }
    }
}
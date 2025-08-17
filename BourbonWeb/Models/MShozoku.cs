using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�����}�X�^")]
    public class MShozoku
    {
        [Column("SYSTEM_KBN")]
        [Display(Name = "�V�X�e���敪")]
        public string? SystemKbn { get; set; }

        [Column("KAISHA_CD")]
        [Display(Name = "���CD")]
        public string? KaishaCd { get; set; }

        [Column("SHOZOKU_CD")]
        [Display(Name = "����CD")]
        public string? ShozokuCd { get; set; }

        [Column("KY_KAISI_YMD")]
        [Display(Name = "�J�n�N����")]
        public string? KyKaisiYmd { get; set; }

        [Column("KY_SHURYO_YMD")]
        [Display(Name = "�I���N����")]
        public string? KyShuryoYmd { get; set; }

        [Column("SHOZOKU_KAISHA_NM")]
        [Display(Name = "������Ж�")]
        public string? ShozokuKaishaNm { get; set; }

        [Column("SHOZOKU_HONBU_NM")]
        [Display(Name = "�����{����")]
        public string? ShozokuHonbuNm { get; set; }

        [Column("SHOZOKU_BUMON_NM1")]
        [Display(Name = "�������喼1")]
        public string? ShozokuBumonNm1 { get; set; }

        [Column("SHOZOKU_BUMON_NM2")]
        [Display(Name = "�������喼2")]
        public string? ShozokuBumonNm2 { get; set; }

        [Column("SHOZOKU_NM1")]
        [Display(Name = "������1")]
        public string? ShozokuNm1 { get; set; }

        [Column("SHOZOKU_NM2")]
        [Display(Name = "������2")]
        public string? ShozokuNm2 { get; set; }

        [Column("SHOZOKU_ORDER")]
        [Display(Name = "�����\�[�g��")]
        public short? ShozokuOrder { get; set; }

        [Column("SHOZOKU_HYOJI")]
        [Display(Name = "�����\��")]
        public bool? ShozokuHyoji { get; set; }

        [Column("KA_JIGYOSHO_CD")]
        [Display(Name = "��Ў��Ə�CD")]
        public string? KaJigyoushoCd { get; set; }

        [Column("KA_KBN1")]
        [Display(Name = "��Ћ敪1")]
        public string? KaKbn1 { get; set; }

        [Column("KA_KBN2")]
        [Display(Name = "��Ћ敪2")]
        public string? KaKbn2 { get; set; }

        [Column("KA_CD")]
        [Display(Name = "���CD")]
        public string? KaCd { get; set; }

        [Column("KA_REMARKS")]
        [Display(Name = "���l")]
        public string? KaRemarks { get; set; }

        [Column("KOZA_SIKIBETU_CD")]
        [Display(Name = "��������CD")]
        public string? KozaSikibetuCd { get; set; }

        [Column("REMARKS")]
        [Display(Name = "���l")]
        public string? Remarks { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "�o�^��")]
        public string? CreatedId { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "�o�^��")]
        public DateTime? CreatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "�X�V��")]
        public string? UpdatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "�X�V��")]
        public DateTime? UpdatedAt { get; set; }

        [Column("DELETED_FLG")]
        [Display(Name = "�폜�t���O")]
        public bool? DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "���b�N�o�[�W����")]
        public int? LockVersion { get; set; }

    }
}
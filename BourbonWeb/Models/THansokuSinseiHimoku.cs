using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "販促費申請費目明細")]
    public class THansokuSinseiHimoku
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

        [Column("DENPYO_KBN")]
        [Display(Name = "伝票区分")]
        public string? DenpyoKbn { get; set; }

        [Column("HANSOK_KBN")]
        [Display(Name = "販促区分")]
        public string? HansokKbn { get; set; }

        [Column("HANSOK_KBN_SHOSAI")]
        [Display(Name = "販促区分詳細")]
        public string? HansokKbnShosai { get; set; }

        [Column("HANSOK_KBN_KOBETU")]
        [Display(Name = "販促区分個別")]
        public string? HansokKbnKobetu { get; set; }

        [Column("HANSOK_HIMOKU_NM_A")]
        [Display(Name = "販促費目別名A")]
        public string? HansokHimokuNmA { get; set; }

        [Column("HANSOK_HIMOKU_NM_B")]
        [Display(Name = "販促費目別名B")]
        public string? HansokHimokuNmB { get; set; }

        [Column("HANSOK_HIMOKU_ORDER")]
        [Display(Name = "販促費名称表示順")]
        public int? HansokHimokuOrder { get; set; }

        [Column("KYOSAN_JOKEN")]
        [Display(Name = "協賛条件")]
        public decimal? KyosanJoken { get; set; }

        [Column("KYOSAN_GAKU")]
        [Display(Name = "協賛額")]
        public decimal? KyosanGaku { get; set; }

        [Column("KYOSAN_GAKU_CHOSEI")]
        [Display(Name = "協賛額調整")]
        public decimal? KyosanGakuChosei { get; set; }

        [Column("KYOSAN_GAKU_ZEI_KBN")]
        [Display(Name = "協賛額消費税区分")]
        public string? KyosanGakuZeiKbn { get; set; }

        [Column("KYOSAN_GAKU_ZEI_GAKU")]
        [Display(Name = "協賛額消費税額")]
        public decimal? KyosanGakuZeiGaku { get; set; }

        [Column("AREA_TAISHO_YM")]
        [Display(Name = "エリア・対象年月")]
        public string? AreaTaishoYm { get; set; }

        [Column("AREA_HANSOKU_KBN")]
        [Display(Name = "エリア・販促区分")]
        public string? AreaHansokuKbn { get; set; }

        [Column("AREA_HANSOKU_KBN_SHOSAI")]
        [Display(Name = "エリア・販促区分詳細")]
        public string? AreaHansokuKbnShosai { get; set; }

        [Column("AREA_SHO_CD")]
        [Display(Name = "エリア・担当所コード")]
        public string? AreaShoCd { get; set; }

        [Column("AREA_SALES_CD")]
        [Display(Name = "エリア・担当者コード")]
        public string? AreaSalesCd { get; set; }

        [Column("AREA_TOKUI_CD")]
        [Display(Name = "エリア・得意先コード")]
        public string? AreaTokuiCd { get; set; }

        [Column("AREA_KOBETU_CD")]
        [Display(Name = "エリア・個別コード")]
        public string? AreaKobetuCd { get; set; }

        [Column("NEBK_DENPYO_NO")]
        [Display(Name = "売掛値引伝票番号")]
        public string? NebkDenpyoNo { get; set; }

        [Column("NEBK_GAITOU_DATE")]
        [Display(Name = "売掛値引該当年月")]
        public string? NebkGaitouDate { get; set; }

        [Column("NEBK_SEIKYU_KBN")]
        [Display(Name = "売掛値引請求区分")]
        public string? NebkSeikyuKbn { get; set; }

        [Column("NEBK_SHOP_CD")]
        [Display(Name = "売掛値引請求先コード")]
        public string? NebkShopCd { get; set; }

        [Column("NEBK_RENKEI_DATE")]
        [Display(Name = "売掛連携日時")]
        public DateTime? NebkRenkeiDate { get; set; }

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

        [Column("SHOHIZEI_RITU")]
        [Display(Name = "消費税率")]
        public decimal? ShohizeiRitu { get; set; }

        [Column("ZEI_RITU_KBN")]
        [Display(Name = "税率区分")]
        public string? ZeiRituKbn { get; set; }

        [Column("ITTAI_SISAN_KBN")]
        [Display(Name = "一帯資産区分")]
        public string? IttaiSisanKbn { get; set; }

        [Column("KEIHI_BUNRUI")]
        [Display(Name = "経費分類")]
        public string? KeihiBunrui { get; set; }

        [Column("URIAGE_KOUJYO_HANTEI")]
        [Display(Name = "売上控除判定")]
        public string? UriageKoujyoHantei { get; set; }
    }
}
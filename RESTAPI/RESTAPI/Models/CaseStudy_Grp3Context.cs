using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RESTAPI.Models
{
    public partial class CaseStudy_Grp3Context : DbContext
    {
        public CaseStudy_Grp3Context()
        {

        }

        public CaseStudy_Grp3Context(DbContextOptions<CaseStudy_Grp3Context> options) : base(options)
        {
        }

        public virtual DbSet<Baudit> Baudits { get; set; } = null!;
        public virtual DbSet<Bond> Bonds { get; set; } = null!;
        public virtual DbSet<CallSchedule> CallSchedules { get; set; } = null!;
        public virtual DbSet<DividendHistory> DividendHistories { get; set; } = null!;
        public virtual DbSet<Eaudit> Eaudits { get; set; } = null!;
        public virtual DbSet<Equity> Equities { get; set; } = null!;
        public virtual DbSet<PricingAnalytic> PricingAnalytics { get; set; } = null!;
        public virtual DbSet<PricingDetail> PricingDetails { get; set; } = null!;
        public virtual DbSet<PutSchedule> PutSchedules { get; set; } = null!;
        public virtual DbSet<ReferenceDatum> ReferenceData { get; set; } = null!;
        public virtual DbSet<ReferenceDatum1> ReferenceData1 { get; set; } = null!;
        public virtual DbSet<RegulatoryDetail> RegulatoryDetails { get; set; } = null!;
        public virtual DbSet<RegulatoryDetail1> RegulatoryDetails1 { get; set; } = null!;
        public virtual DbSet<Risk> Risks { get; set; } = null!;
        public virtual DbSet<Risk1> Risks1 { get; set; } = null!;
        public virtual DbSet<SecurityDetail> SecurityDetails { get; set; } = null!;
        public virtual DbSet<SecurityDetail1> SecurityDetails1 { get; set; } = null!;
        public virtual DbSet<SecurityIdentifier> SecurityIdentifiers { get; set; } = null!;
        public virtual DbSet<SecurityIdentifier1> SecurityIdentifiers1 { get; set; } = null!;
        public virtual DbSet<SecuritySummary> SecuritySummaries { get; set; } = null!;
        public virtual DbSet<SecuritySummary1> SecuritySummaries1 { get; set; } = null!;
        public virtual DbSet<VuEquityInfo> VuEquityInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.0.13\\SQLEXPRESS,58264;Initial Catalog=CaseStudy_Grp3;User ID=sa;password=sa@12345678;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Baudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BAudit");

                entity.Property(e => e.BsecId).HasColumnName("BSecId");

                entity.Property(e => e.BsecName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewAskPrice).HasColumnName("New_AskPrice");

                entity.Property(e => e.NewCallable).HasColumnName("New_Callable");

                entity.Property(e => e.NewCouponRate).HasColumnName("New_CouponRate");

                entity.Property(e => e.NewPenUltimateCouponDate)
                    .HasColumnType("date")
                    .HasColumnName("New_PenUltimateCouponDate");

                entity.Property(e => e.NewPfcreditRating)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_PFCreditRating");

                entity.Property(e => e.NewSecDesc)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("New_SecDesc");

                entity.Property(e => e.OldAskPrice).HasColumnName("Old_AskPrice");

                entity.Property(e => e.OldCallable).HasColumnName("Old_Callable");

                entity.Property(e => e.OldCouponRate).HasColumnName("Old_CouponRate");

                entity.Property(e => e.OldPenUltimateCouponDate)
                    .HasColumnType("date")
                    .HasColumnName("Old_PenUltimateCouponDate");

                entity.Property(e => e.OldPfcreditRating)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_PFCreditRating");

                entity.Property(e => e.OldSecDesc)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("Old_SecDesc");

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.XnDate).HasColumnType("datetime");

                entity.Property(e => e.XnType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bond>(entity =>
            {
                entity.HasKey(e => e.SecId)
                    .HasName("PK__Bonds__14A369BF171824A3");

                entity.Property(e => e.SecId).ValueGeneratedNever();

                entity.Property(e => e.AssestType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BbgindustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGIndustryGroup");

                entity.Property(e => e.BbgindustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGIndustrySubGroup");

                entity.Property(e => e.Bbgsector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGSector");

                entity.Property(e => e.Bbgticker)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BBGTicker");

                entity.Property(e => e.BbguniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGUniqueId");

                entity.Property(e => e.CallDate).HasColumnType("date");

                entity.Property(e => e.CouponCap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CouponFloor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CouponType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cusip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.FirstCouponDate).HasColumnType("date");

                entity.Property(e => e.FloatSpread)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvestmentType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Isin)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastResetDate).HasColumnType("date");

                entity.Property(e => e.MaturityDate).HasColumnType("date");

                entity.Property(e => e.NinetyDvolatility).HasColumnName("NinetyDVolatility");

                entity.Property(e => e.PenUltimateCouponDate).HasColumnType("date");

                entity.Property(e => e.PfassetClasses)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFAssetClasses");

                entity.Property(e => e.Pfcountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFCountry");

                entity.Property(e => e.PfcreditRating)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PFCreditRating");

                entity.Property(e => e.Pfcurrency)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PFCurrency");

                entity.Property(e => e.Pfinstrument)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFInstrument");

                entity.Property(e => e.PfliquidityProfile)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PFLiquidityProfile");

                entity.Property(e => e.Pfmaturity)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PFMaturity");

                entity.Property(e => e.Pfnaicscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFNAICSCode");

                entity.Property(e => e.Pfregion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFRegion");

                entity.Property(e => e.Pfsector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFSector");

                entity.Property(e => e.PfsubAssetClass)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PFSubAssetClass");

                entity.Property(e => e.PutDate).HasColumnType("date");

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sedol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.ThirtyDaverageVolume).HasColumnName("ThirtyDAverageVolume");

                entity.Property(e => e.ThirtyDvolatility).HasColumnName("ThirtyDVolatility");
            });

            modelBuilder.Entity<CallSchedule>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__CallSche__CA1959706D8658A8");

                entity.ToTable("CallSchedule", "Bonds");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.CallDate).HasColumnType("date");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.CallSchedule)
                    .HasForeignKey<CallSchedule>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CallSchedul__SID__0B91BA14");
            });

            modelBuilder.Entity<DividendHistory>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Dividend__CA195970FA379325");

                entity.ToTable("DividendHistory", "Equities");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.DeclaredDate).HasColumnType("date");

                entity.Property(e => e.DividendType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExDate).HasColumnType("date");

                entity.Property(e => e.PayDate).HasColumnType("date");

                entity.Property(e => e.RecordDate).HasColumnType("date");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.DividendHistory)
                    .HasForeignKey<DividendHistory>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DividendHis__SID__72C60C4A");
            });

            modelBuilder.Entity<Eaudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EAudit");

                entity.Property(e => e.EsecId).HasColumnName("ESecId");

                entity.Property(e => e.EsecName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewDivDecDate)
                    .HasColumnType("date")
                    .HasColumnName("New_DivDecDate");

                entity.Property(e => e.NewOpenPrice).HasColumnName("New_OpenPrice");

                entity.Property(e => e.NewPfcr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_PFCR");

                entity.Property(e => e.NewPriceCurr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_PriceCurr");

                entity.Property(e => e.NewSecDesc)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("New_SecDesc");

                entity.Property(e => e.OldClosePrice).HasColumnName("Old_ClosePrice");

                entity.Property(e => e.OldDivDecDate)
                    .HasColumnType("date")
                    .HasColumnName("Old_DivDecDate");

                entity.Property(e => e.OldOpenPrice).HasColumnName("Old_OpenPrice");

                entity.Property(e => e.OldPfcr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_PFCR");

                entity.Property(e => e.OldPriceCurr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Old_PriceCurr");

                entity.Property(e => e.OldSecDesc)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("Old_SecDesc");

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.XnDate).HasColumnType("datetime");

                entity.Property(e => e.XnType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Equity>(entity =>
            {
                entity.HasKey(e => e.SecId)
                    .HasName("PK__Equities__14A369BF11CD323C");

                entity.Property(e => e.SecId).ValueGeneratedNever();

                entity.Property(e => e.AdrunderlyingCurrency)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ADRUnderlyingCurrency");

                entity.Property(e => e.AdrunderlyingTicker)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ADRUnderlyingTicker");

                entity.Property(e => e.BbgglobalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGGlobalId");

                entity.Property(e => e.BbgindustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGIndustryGroup");

                entity.Property(e => e.BbgindustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGIndustrySector");

                entity.Property(e => e.BbgindustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGIndustrySubGroup");

                entity.Property(e => e.Bbgticker)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BBGTicker");

                entity.Property(e => e.BbguniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGUniqueId");

                entity.Property(e => e.BbguniqueName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGUniqueName");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.DeclaredDate).HasColumnType("date");

                entity.Property(e => e.DividendType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExDate).HasColumnType("date");

                entity.Property(e => e.Exchange)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IncorporationCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipodate)
                    .HasColumnType("date")
                    .HasColumnName("IPODate");

                entity.Property(e => e.IsAdrflag).HasColumnName("IsADRFlag");

                entity.Property(e => e.Isin)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NinetyDpriceVolatility).HasColumnName("NinetyDPriceVolatility");

                entity.Property(e => e.PayDate).HasColumnType("date");

                entity.Property(e => e.Peratio).HasColumnName("PERatio");

                entity.Property(e => e.PfassetClasses)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFAssetClasses");

                entity.Property(e => e.Pfcountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFCountry");

                entity.Property(e => e.PfcreditRating)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PFCreditRating");

                entity.Property(e => e.Pfcurrency)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PFCurrency");

                entity.Property(e => e.Pfinstrument)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFInstrument");

                entity.Property(e => e.PfliquidityProfile)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFLiquidityProfile");

                entity.Property(e => e.Pfmaturity)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFMaturity");

                entity.Property(e => e.Pfnaicscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFNAICSCode");

                entity.Property(e => e.Pfregion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFRegion");

                entity.Property(e => e.Pfsector)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFSector");

                entity.Property(e => e.PfsubAssetClass)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PFSubAssetClass");

                entity.Property(e => e.PriceCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RecordDate).HasColumnType("date");

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sedol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.SharesPerAdr).HasColumnName("SharesPerADR");

                entity.Property(e => e.TickerExchange)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TradingCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TwentyDaverageVolume).HasColumnName("TwentyDAverageVolume");

                entity.Property(e => e.Ytdreturn).HasColumnName("YTDReturn");
            });

            modelBuilder.Entity<PricingAnalytic>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__PricingA__CA195970138EFD92");

                entity.ToTable("PricingAnalytics", "Bonds");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.PricingAnalytic)
                    .HasForeignKey<PricingAnalytic>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PricingAnal__SID__05D8E0BE");
            });

            modelBuilder.Entity<PricingDetail>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__PricingD__CA1959707FE5246F");

                entity.ToTable("PricingDetails", "Equities");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.Peratio).HasColumnName("PERatio");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.PricingDetail)
                    .HasForeignKey<PricingDetail>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PricingDeta__SID__6FE99F9F");
            });

            modelBuilder.Entity<PutSchedule>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__PutSched__CA195970266910A0");

                entity.ToTable("PutSchedule", "Bonds");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.PutDate).HasColumnType("date");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.PutSchedule)
                    .HasForeignKey<PutSchedule>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PutSchedule__SID__08B54D69");
            });

            modelBuilder.Entity<ReferenceDatum>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Referenc__CA19597039D38A1E");

                entity.ToTable("ReferenceData", "Bonds");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.BbgindustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGIndustryGroup");

                entity.Property(e => e.BbgindustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGIndustrySubGroup");

                entity.Property(e => e.Bbgsector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGSector");

                entity.Property(e => e.IssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.ReferenceDatum)
                    .HasForeignKey<ReferenceDatum>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReferenceDa__SID__46E78A0C");
            });

            modelBuilder.Entity<ReferenceDatum1>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Referenc__CA195970793E5731");

                entity.ToTable("ReferenceData", "Equities");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.BbgindustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGIndustryGroup");

                entity.Property(e => e.BbgindustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGIndustrySector");

                entity.Property(e => e.BbgindustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGIndustrySubGroup");

                entity.Property(e => e.Exchange)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IncorporationCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TradingCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.ReferenceDatum1)
                    .HasForeignKey<ReferenceDatum1>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReferenceDa__SID__2C3393D0");
            });

            modelBuilder.Entity<RegulatoryDetail>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Regulato__CA195970B9B6C7AA");

                entity.ToTable("RegulatoryDetails", "Bonds");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.PfassetClasses)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFAssetClasses")
                    .HasDefaultValueSql("('Credit')");

                entity.Property(e => e.Pfcountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFCountry");

                entity.Property(e => e.PfcreditRating)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PFCreditRating");

                entity.Property(e => e.Pfcurrency)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PFCurrency");

                entity.Property(e => e.Pfinstrument)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFInstrument")
                    .HasDefaultValueSql("('Securities')");

                entity.Property(e => e.PfliquidityProfile)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PFLiquidityProfile");

                entity.Property(e => e.Pfmaturity)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PFMaturity");

                entity.Property(e => e.Pfnaicscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFNAICSCode");

                entity.Property(e => e.Pfregion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFRegion");

                entity.Property(e => e.Pfsector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFSector");

                entity.Property(e => e.PfsubAssetClass)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PFSubAssetClass");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.RegulatoryDetail)
                    .HasForeignKey<RegulatoryDetail>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RegulatoryD__SID__01142BA1");
            });

            modelBuilder.Entity<RegulatoryDetail1>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Regulato__CA195970F6C0C96E");

                entity.ToTable("RegulatoryDetails", "Equities");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.PfassetClasses)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFAssetClasses")
                    .HasDefaultValueSql("('Equity')");

                entity.Property(e => e.Pfcountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFCountry");

                entity.Property(e => e.PfcreditRating)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PFCreditRating");

                entity.Property(e => e.Pfcurrency)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PFCurrency");

                entity.Property(e => e.Pfinstrument)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFInstrument")
                    .HasDefaultValueSql("('Securities')");

                entity.Property(e => e.PfliquidityProfile)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFLiquidityProfile");

                entity.Property(e => e.Pfmaturity)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFMaturity");

                entity.Property(e => e.Pfnaicscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFNAICSCode");

                entity.Property(e => e.Pfregion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFRegion");

                entity.Property(e => e.Pfsector)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PFSector");

                entity.Property(e => e.PfsubAssetClass)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PFSubAssetClass");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.RegulatoryDetail1)
                    .HasForeignKey<RegulatoryDetail1>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RegulatoryD__SID__276EDEB3");
            });

            modelBuilder.Entity<Risk>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Risk__CA19597048DB9FD7");

                entity.ToTable("Risk", "Bonds");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.NinetyDvolatility).HasColumnName("NinetyDVolatility");

                entity.Property(e => e.ThirtyDaverageVolume).HasColumnName("ThirtyDAverageVolume");

                entity.Property(e => e.ThirtyDvolatility).HasColumnName("ThirtyDVolatility");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.Risk)
                    .HasForeignKey<Risk>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Risk__SID__797309D9");
            });

            modelBuilder.Entity<Risk1>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Risk__CA1959703300B98B");

                entity.ToTable("Risk", "Equities");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.NinetyDpriceVolatility).HasColumnName("NinetyDPriceVolatility");

                entity.Property(e => e.TwentyDaverageVolume).HasColumnName("TwentyDAverageVolume");

                entity.Property(e => e.Ytdreturn).HasColumnName("YTDReturn");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.Risk1)
                    .HasForeignKey<Risk1>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Risk__SID__6A30C649");
            });

            modelBuilder.Entity<SecurityDetail>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Security__CA195970A179E598");

                entity.ToTable("SecurityDetails", "Bonds");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.CouponCap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CouponFloor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CouponType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Fixed')");

                entity.Property(e => e.FirstCouponDate).HasColumnType("date");

                entity.Property(e => e.FloatSpread)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.LastResetDate).HasColumnType("date");

                entity.Property(e => e.MaturityDate).HasColumnType("date");

                entity.Property(e => e.PenUltimateCouponDate).HasColumnType("date");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.SecurityDetail)
                    .HasForeignKey<SecurityDetail>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SecurityDet__SID__75A278F5");
            });

            modelBuilder.Entity<SecurityDetail1>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Security__CA195970CFE419B1");

                entity.ToTable("SecurityDetails", "Equities");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.AdrunderlyingCurrency)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ADRUnderlyingCurrency");

                entity.Property(e => e.AdrunderlyingTicker)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ADRUnderlyingTicker");

                entity.Property(e => e.Ipodate)
                    .HasColumnType("date")
                    .HasColumnName("IPODate");

                entity.Property(e => e.IsAdrflag)
                    .HasColumnName("IsADRFlag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PriceCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SharesPerAdr).HasColumnName("SharesPerADR");

                entity.Property(e => e.VotingRightsPerShare).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.SecurityDetail1)
                    .HasForeignKey<SecurityDetail1>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SecurityDet__SID__656C112C");
            });

            modelBuilder.Entity<SecurityIdentifier>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Security__CA195970423B81CD");

                entity.ToTable("SecurityIdentifier", "Bonds");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.Bbgticker)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BBGTicker");

                entity.Property(e => e.BbguniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGUniqueId");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.Isin)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.SecurityIdentifier)
                    .HasForeignKey<SecurityIdentifier>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SecurityIde__SID__38996AB5");
            });

            modelBuilder.Entity<SecurityIdentifier1>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Security__CA1959702F739332");

                entity.ToTable("SecurityIdentifier", "Equities");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.BbgglobalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGGlobalId");

                entity.Property(e => e.Bbgticker)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BBGTicker");

                entity.Property(e => e.BbguniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGUniqueId");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.Isin)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.TickerExchange)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.SecurityIdentifier1)
                    .HasForeignKey<SecurityIdentifier1>(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SecurityIde__SID__173876EA");
            });

            modelBuilder.Entity<SecuritySummary>(entity =>
            {
                entity.HasKey(e => e.SecId)
                    .HasName("PK__Security__14A369BF85BFAF37");

                entity.ToTable("SecuritySummary", "Bonds");

                entity.Property(e => e.AssestType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Fixed Income')");

                entity.Property(e => e.InvestmentType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Corporate Bond')");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecuritySummary1>(entity =>
            {
                entity.HasKey(e => e.SecId)
                    .HasName("PK__Security__14A369BFE4B2F73C");

                entity.ToTable("SecuritySummary", "Equities");

                entity.HasIndex(e => e.BbguniqueName, "UQ__Security__51E074AD141B75E4")
                    .IsUnique();

                entity.Property(e => e.BbguniqueName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BBGUniqueName");

                entity.Property(e => e.RoundLotSize).HasDefaultValueSql("((100))");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VuEquityInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vuEquityInfo");

                entity.Property(e => e.DeclaredDate).HasColumnType("date");

                entity.Property(e => e.PfcreditRating)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PFCreditRating");

                entity.Property(e => e.PriceCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemirbasOtomasyon.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DemirbasTakipEntitiess : DbContext
    {
        public DemirbasTakipEntitiess()
            : base("name=DemirbasTakipEntitiess")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Departmanlar> Departmanlar { get; set; }
        public virtual DbSet<Kullanıcılar> Kullanıcılar { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<Roller> Roller { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Zimmetler> Zimmetler { get; set; }
        public virtual DbSet<Atıklar> Atıklar { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_PersonelBul_Result> sp_PersonelBul(Nullable<int> personelID)
        {
            var personelIDParameter = personelID.HasValue ?
                new ObjectParameter("personelID", personelID) :
                new ObjectParameter("personelID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_PersonelBul_Result>("sp_PersonelBul", personelIDParameter);
        }
    
        public virtual int sp_PersonelEkle(string adi, string soyadi, string cepTelefonu, Nullable<int> departmanID, Nullable<System.DateTime> iseGirisTarihi)
        {
            var adiParameter = adi != null ?
                new ObjectParameter("adi", adi) :
                new ObjectParameter("adi", typeof(string));
    
            var soyadiParameter = soyadi != null ?
                new ObjectParameter("soyadi", soyadi) :
                new ObjectParameter("soyadi", typeof(string));
    
            var cepTelefonuParameter = cepTelefonu != null ?
                new ObjectParameter("cepTelefonu", cepTelefonu) :
                new ObjectParameter("cepTelefonu", typeof(string));
    
            var departmanIDParameter = departmanID.HasValue ?
                new ObjectParameter("departmanID", departmanID) :
                new ObjectParameter("departmanID", typeof(int));
    
            var iseGirisTarihiParameter = iseGirisTarihi.HasValue ?
                new ObjectParameter("iseGirisTarihi", iseGirisTarihi) :
                new ObjectParameter("iseGirisTarihi", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_PersonelEkle", adiParameter, soyadiParameter, cepTelefonuParameter, departmanIDParameter, iseGirisTarihiParameter);
        }
    
        public virtual ObjectResult<sp_PersonelListele_Result> sp_PersonelListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_PersonelListele_Result>("sp_PersonelListele");
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int sp_UrunEkle(string urunAdi, Nullable<decimal> fiyat, Nullable<int> stokMiktari, Nullable<System.DateTime> satinAlinmaTarihi)
        {
            var urunAdiParameter = urunAdi != null ?
                new ObjectParameter("urunAdi", urunAdi) :
                new ObjectParameter("urunAdi", typeof(string));
    
            var fiyatParameter = fiyat.HasValue ?
                new ObjectParameter("fiyat", fiyat) :
                new ObjectParameter("fiyat", typeof(decimal));
    
            var stokMiktariParameter = stokMiktari.HasValue ?
                new ObjectParameter("stokMiktari", stokMiktari) :
                new ObjectParameter("stokMiktari", typeof(int));
    
            var satinAlinmaTarihiParameter = satinAlinmaTarihi.HasValue ?
                new ObjectParameter("satinAlinmaTarihi", satinAlinmaTarihi) :
                new ObjectParameter("satinAlinmaTarihi", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UrunEkle", urunAdiParameter, fiyatParameter, stokMiktariParameter, satinAlinmaTarihiParameter);
        }
    
        public virtual int sp_UrunGuncelle(Nullable<int> urunID, string urunAdi, Nullable<decimal> fiyat, Nullable<int> stokMiktari, Nullable<System.DateTime> satinAlinmaTarihi)
        {
            var urunIDParameter = urunID.HasValue ?
                new ObjectParameter("urunID", urunID) :
                new ObjectParameter("urunID", typeof(int));
    
            var urunAdiParameter = urunAdi != null ?
                new ObjectParameter("urunAdi", urunAdi) :
                new ObjectParameter("urunAdi", typeof(string));
    
            var fiyatParameter = fiyat.HasValue ?
                new ObjectParameter("fiyat", fiyat) :
                new ObjectParameter("fiyat", typeof(decimal));
    
            var stokMiktariParameter = stokMiktari.HasValue ?
                new ObjectParameter("stokMiktari", stokMiktari) :
                new ObjectParameter("stokMiktari", typeof(int));
    
            var satinAlinmaTarihiParameter = satinAlinmaTarihi.HasValue ?
                new ObjectParameter("satinAlinmaTarihi", satinAlinmaTarihi) :
                new ObjectParameter("satinAlinmaTarihi", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UrunGuncelle", urunIDParameter, urunAdiParameter, fiyatParameter, stokMiktariParameter, satinAlinmaTarihiParameter);
        }
    
        public virtual ObjectResult<sp_UrunListele_Result> sp_UrunListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_UrunListele_Result>("sp_UrunListele");
        }
    
        public virtual ObjectResult<sp_ZimmetBul_Result> sp_ZimmetBul(Nullable<int> zimmetID)
        {
            var zimmetIDParameter = zimmetID.HasValue ?
                new ObjectParameter("zimmetID", zimmetID) :
                new ObjectParameter("zimmetID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ZimmetBul_Result>("sp_ZimmetBul", zimmetIDParameter);
        }
    
        public virtual int sp_ZimmetEkle(Nullable<int> urunID, Nullable<System.DateTime> zimmetTarihi, Nullable<int> zimmetAdet, Nullable<int> personelID, Nullable<int> kullaniciID)
        {
            var urunIDParameter = urunID.HasValue ?
                new ObjectParameter("urunID", urunID) :
                new ObjectParameter("urunID", typeof(int));
    
            var zimmetTarihiParameter = zimmetTarihi.HasValue ?
                new ObjectParameter("zimmetTarihi", zimmetTarihi) :
                new ObjectParameter("zimmetTarihi", typeof(System.DateTime));
    
            var zimmetAdetParameter = zimmetAdet.HasValue ?
                new ObjectParameter("zimmetAdet", zimmetAdet) :
                new ObjectParameter("zimmetAdet", typeof(int));
    
            var personelIDParameter = personelID.HasValue ?
                new ObjectParameter("personelID", personelID) :
                new ObjectParameter("personelID", typeof(int));
    
            var kullaniciIDParameter = kullaniciID.HasValue ?
                new ObjectParameter("kullaniciID", kullaniciID) :
                new ObjectParameter("kullaniciID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ZimmetEkle", urunIDParameter, zimmetTarihiParameter, zimmetAdetParameter, personelIDParameter, kullaniciIDParameter);
        }
    
        public virtual int sp_ZimmetKaldir(Nullable<int> zimmetID)
        {
            var zimmetIDParameter = zimmetID.HasValue ?
                new ObjectParameter("zimmetID", zimmetID) :
                new ObjectParameter("zimmetID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ZimmetKaldir", zimmetIDParameter);
        }
    
        public virtual ObjectResult<sp_ZimmetListele_Result> sp_ZimmetListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ZimmetListele_Result>("sp_ZimmetListele");
        }
    
        public virtual int sp_UrunSil(Nullable<int> urunID)
        {
            var urunIDParameter = urunID.HasValue ?
                new ObjectParameter("urunID", urunID) :
                new ObjectParameter("urunID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UrunSil", urunIDParameter);
        }
    
        public virtual ObjectResult<sp_ZimmetListele2_Result> sp_ZimmetListele2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ZimmetListele2_Result>("sp_ZimmetListele2");
        }
    
        public virtual int sp_PersonelGuncelle(Nullable<int> personelID, string personelAdi, string personelSoyadi, string cepTelefonu, Nullable<int> departmanID, Nullable<System.DateTime> iseGirisTarihi)
        {
            var personelIDParameter = personelID.HasValue ?
                new ObjectParameter("personelID", personelID) :
                new ObjectParameter("personelID", typeof(int));
    
            var personelAdiParameter = personelAdi != null ?
                new ObjectParameter("personelAdi", personelAdi) :
                new ObjectParameter("personelAdi", typeof(string));
    
            var personelSoyadiParameter = personelSoyadi != null ?
                new ObjectParameter("personelSoyadi", personelSoyadi) :
                new ObjectParameter("personelSoyadi", typeof(string));
    
            var cepTelefonuParameter = cepTelefonu != null ?
                new ObjectParameter("cepTelefonu", cepTelefonu) :
                new ObjectParameter("cepTelefonu", typeof(string));
    
            var departmanIDParameter = departmanID.HasValue ?
                new ObjectParameter("departmanID", departmanID) :
                new ObjectParameter("departmanID", typeof(int));
    
            var iseGirisTarihiParameter = iseGirisTarihi.HasValue ?
                new ObjectParameter("iseGirisTarihi", iseGirisTarihi) :
                new ObjectParameter("iseGirisTarihi", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_PersonelGuncelle", personelIDParameter, personelAdiParameter, personelSoyadiParameter, cepTelefonuParameter, departmanIDParameter, iseGirisTarihiParameter);
        }
    
        public virtual int sp_PersonelSil(Nullable<int> personelID)
        {
            var personelIDParameter = personelID.HasValue ?
                new ObjectParameter("personelID", personelID) :
                new ObjectParameter("personelID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_PersonelSil", personelIDParameter);
        }
    
        public virtual ObjectResult<sp_PersonelListele2_Result> sp_PersonelListele2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_PersonelListele2_Result>("sp_PersonelListele2");
        }
    
        public virtual int sp_PersonelSil2(Nullable<int> personelID)
        {
            var personelIDParameter = personelID.HasValue ?
                new ObjectParameter("personelID", personelID) :
                new ObjectParameter("personelID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_PersonelSil2", personelIDParameter);
        }
    
        [DbFunction("DemirbasTakipEntitiess", "FN_UrunIDGetir")]
        public virtual IQueryable<FN_UrunIDGetir_Result> FN_UrunIDGetir(Nullable<int> personelID)
        {
            var personelIDParameter = personelID.HasValue ?
                new ObjectParameter("personelID", personelID) :
                new ObjectParameter("personelID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FN_UrunIDGetir_Result>("[DemirbasTakipEntitiess].[FN_UrunIDGetir](@personelID)", personelIDParameter);
        }
    
        public virtual int sp_ZimmetGuncelle(Nullable<int> zimmetID, Nullable<System.DateTime> zimmetTarihi, Nullable<int> zimmetAdet, Nullable<int> personelID, Nullable<int> kullaniciID)
        {
            var zimmetIDParameter = zimmetID.HasValue ?
                new ObjectParameter("zimmetID", zimmetID) :
                new ObjectParameter("zimmetID", typeof(int));
    
            var zimmetTarihiParameter = zimmetTarihi.HasValue ?
                new ObjectParameter("zimmetTarihi", zimmetTarihi) :
                new ObjectParameter("zimmetTarihi", typeof(System.DateTime));
    
            var zimmetAdetParameter = zimmetAdet.HasValue ?
                new ObjectParameter("zimmetAdet", zimmetAdet) :
                new ObjectParameter("zimmetAdet", typeof(int));
    
            var personelIDParameter = personelID.HasValue ?
                new ObjectParameter("personelID", personelID) :
                new ObjectParameter("personelID", typeof(int));
    
            var kullaniciIDParameter = kullaniciID.HasValue ?
                new ObjectParameter("kullaniciID", kullaniciID) :
                new ObjectParameter("kullaniciID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ZimmetGuncelle", zimmetIDParameter, zimmetTarihiParameter, zimmetAdetParameter, personelIDParameter, kullaniciIDParameter);
        }
    
        public virtual ObjectResult<sp_ZimmetListeleGuncelleme_Result> sp_ZimmetListeleGuncelleme()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ZimmetListeleGuncelleme_Result>("sp_ZimmetListeleGuncelleme");
        }
    
        public virtual ObjectResult<sp_ZimmetBul2_Result> sp_ZimmetBul2(Nullable<int> zimmetID)
        {
            var zimmetIDParameter = zimmetID.HasValue ?
                new ObjectParameter("zimmetID", zimmetID) :
                new ObjectParameter("zimmetID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ZimmetBul2_Result>("sp_ZimmetBul2", zimmetIDParameter);
        }
    
        public virtual ObjectResult<sp_UrunBul_Result> sp_UrunBul(Nullable<int> urunID)
        {
            var urunIDParameter = urunID.HasValue ?
                new ObjectParameter("urunID", urunID) :
                new ObjectParameter("urunID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_UrunBul_Result>("sp_UrunBul", urunIDParameter);
        }
    
        public virtual ObjectResult<sp_DepartmanaGoreListele_Result> sp_DepartmanaGoreListele(Nullable<int> departmanID)
        {
            var departmanIDParameter = departmanID.HasValue ?
                new ObjectParameter("departmanID", departmanID) :
                new ObjectParameter("departmanID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_DepartmanaGoreListele_Result>("sp_DepartmanaGoreListele", departmanIDParameter);
        }
    
        public virtual ObjectResult<sp_ZimmetListeleDepartmanaGore_Result> sp_ZimmetListeleDepartmanaGore(Nullable<int> departmanID)
        {
            var departmanIDParameter = departmanID.HasValue ?
                new ObjectParameter("departmanID", departmanID) :
                new ObjectParameter("departmanID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ZimmetListeleDepartmanaGore_Result>("sp_ZimmetListeleDepartmanaGore", departmanIDParameter);
        }
    
        public virtual ObjectResult<sp_PersonelBul2_Result> sp_PersonelBul2(Nullable<int> personelID)
        {
            var personelIDParameter = personelID.HasValue ?
                new ObjectParameter("personelID", personelID) :
                new ObjectParameter("personelID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_PersonelBul2_Result>("sp_PersonelBul2", personelIDParameter);
        }
    
        public virtual int sp_AtikBul(Nullable<int> urunID)
        {
            var urunIDParameter = urunID.HasValue ?
                new ObjectParameter("urunID", urunID) :
                new ObjectParameter("urunID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AtikBul", urunIDParameter);
        }
    
        public virtual int sp_AtikEkle(Nullable<int> zimmetID)
        {
            var zimmetIDParameter = zimmetID.HasValue ?
                new ObjectParameter("zimmetID", zimmetID) :
                new ObjectParameter("zimmetID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AtikEkle", zimmetIDParameter);
        }
    
        public virtual int sp_AtikGeriDondur(Nullable<int> urunID, Nullable<int> stokMiktari)
        {
            var urunIDParameter = urunID.HasValue ?
                new ObjectParameter("urunID", urunID) :
                new ObjectParameter("urunID", typeof(int));
    
            var stokMiktariParameter = stokMiktari.HasValue ?
                new ObjectParameter("stokMiktari", stokMiktari) :
                new ObjectParameter("stokMiktari", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AtikGeriDondur", urunIDParameter, stokMiktariParameter);
        }
    
        public virtual ObjectResult<sp_AtikListele_Result> sp_AtikListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_AtikListele_Result>("sp_AtikListele");
        }
    
        public virtual ObjectResult<sp_AtikListele1_Result> sp_AtikListele1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_AtikListele1_Result>("sp_AtikListele1");
        }
    
        public virtual ObjectResult<sp_AtikListeleme_Result> sp_AtikListeleme()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_AtikListeleme_Result>("sp_AtikListeleme");
        }
    }
}

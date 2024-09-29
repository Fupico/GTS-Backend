namespace GTSProject.Services.Core.Business.Constants
{
    public static class Messages<TEntity> where TEntity : class
    {
        private static string EntityName => typeof(TEntity).Name;

        public static string EntityAdded => $"{EntityName} eklendi.";
        public static string EntityDeleted => $"{EntityName} silindi.";
        public static string EntityUpdated => $"{EntityName} güncellendi.";
        public static string EntityNameInvalid => $"{EntityName} geçersiz.";
        public static string EntityListed => $"{EntityName} listelendi.";
        public static string EntityIdListed => $"{EntityName} ID'ye göre listelendi.";
        public static string EntityNotFound => $"{EntityName} bulunamadı.";
    }
}

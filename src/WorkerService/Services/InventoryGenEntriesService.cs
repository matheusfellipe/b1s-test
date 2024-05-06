using B1SLayer;
using Infrastructure;

namespace WorkerService.Services
{
    public class InventoryGenEntriesService : IInventoryGenEntriesService
    {
        private SLConnection sLConnection;

        public InventoryGenEntriesService(SLConnection sLConnection)
        {
            this.sLConnection = sLConnection;
        }

        public async Task TestGet()
        {
            var GoodsAlreadyEntried = await sLConnection
                                 .Request("InventoryGenEntries")
                                 .Filter($"DocEntry eq '1'")
                                 .Select("Comments,BPLName,DocDate,DocDueDate,DocEntry,DocNum")
                                 .GetAsync<List<InventoryEntriesDto>>();

            if ( GoodsAlreadyEntried != null)
            {
                var obj = GoodsAlreadyEntried.FirstOrDefault();
                Console.WriteLine($"MERCADORIA DOCENTRY {obj.DocEntry} DA FILIAL {obj.BPLName} RETORNANDO");
            } 
        }
    }
}

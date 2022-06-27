var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/inventory/available-verify", (TDDExampleApp.Models.Request.RequestItem requestItem) =>
{
    var responseItem = new TDDExampleApp.Models.Response.Item(requestItem.ProductId, requestItem.Quantity);

    bool available = responseItem.AvailableVerify(responseItem.Quantity);
    responseItem.Available = available;

    return responseItem;
})
.WithName<RouteHandlerBuilder>("InventoryAvailableVerify");

app.Run();
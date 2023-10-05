
namespace CursoParte02.Section14.FixingExerciseInterface.Services.Interfaces;

internal interface IOnlinePaymentService
{
    double PaymentFee(double amount);
    double Interest(double amount, int months);
}

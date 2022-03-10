using FundamentosCSHARP.Errors;
using FundamentosCSHARP.Models;
using FundamentosCSHARP.Service;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FundamentoCSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var buscarChela = new BuscarChela();
                var cantidad = buscarChela.GetCantidad("Pilsen2");
                Console.WriteLine("Todo nice");
            }

            catch(ChelaNoEncontrada ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Cayó en una operación inválida");
            }

            catch (FieldAccessException ex)
            {
                Console.WriteLine("Atrapado prro");
            }

            catch(Exception ex)
            {
                Console.WriteLine("Excepción general");
            }

            finally
            {
                Console.WriteLine("Siempre se ejecuta");
            }
        }    
    }
}

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ControllerCalculadora : ControllerBase
{
    [HttpGet("operar")]
    public IActionResult Operar(string operacion, [FromQuery] int a, [FromQuery] int b)
    {
        double resultadoOperacion;

        switch (operacion.ToLower())
        {
            case "sumar":
                resultadoOperacion = a + b;
                break;
            case "restar":
                resultadoOperacion = a - b;
                break;
            case "multiplicar":
                resultadoOperacion = a * b;
                break;
            case "dividir":
                if (b == 0)
                {
                    return BadRequest(new { error = "No se puede dividir por cero." });
                }
                resultadoOperacion = (double)a / b;
                break;
            default:
                return BadRequest(new { error = "Operación inválida." });
        }

        var resultado = new
        {
            a,
            b,
            operacion,
            resultadoOperacion
        };

        return Ok(resultado);
    }
}
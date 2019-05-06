using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnit
{
    class Program
    {
        static void Main()
        {
            NotaVenta.NotaVentasSoapClient nota = new NotaVenta.NotaVentasSoapClient();


      ///       nota.GrabarNotaVenta()
       
        }


////////        // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
////////        // You can modify the path if necessary.


////////        // Example #1: Write an array of strings to a file.
////////        // Create a string array that consists of three lines.
////////        string[] lines = { "First line", "Second line", "Third line" };
////////        // WriteAllLines creates a file, writes a collection of strings to the file,
////////        // and then closes the file.  You do NOT need to call Flush() or Close().
////////        System.IO.File.WriteAllLines(@"D:\flushes\WriteLines.txt", lines);


////////            // Example #2: Write one string to a text file.
////////            string text = "A class is the most powerful data type in C#. Like a structure, " +
////////                           "a class defines the data and behavior of the data type. ";
////////        // WriteAllText creates a file, writes the specified string to the file,
////////        // and then closes the file.    You do NOT need to call Flush() or Close().
////////        System.IO.File.WriteAllText(@"D:\flushes\WriteText.txt", text);

////////            // Example #3: Write only some strings in an array to a file.
////////            // The using statement automatically flushes AND CLOSES the stream and calls 
////////            // IDisposable.Dispose on the stream object.
////////            // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
////////            // encodes the output as text.
////////            using (System.IO.StreamWriter file =
////////                new System.IO.StreamWriter(@"D:\flushes\WriteLines2.txt"))
////////            {
////////                foreach (string line in lines)
////////                {
////////                    // If the line doesn't contain the word 'Second', write the line to the file.
////////                    if (!line.Contains("Second"))
////////                    {
////////                        file.WriteLine(line);
////////                    }
////////}
////////            }

////////            // Example #4: Append new text to an existing file.
////////            // The using statement automatically flushes AND CLOSES the stream and calls 
////////            // IDisposable.Dispose on the stream object.
////////            using (System.IO.StreamWriter file =
////////                new System.IO.StreamWriter(@"D:\flushes\WriteLines2.txt", true))
////////            {
////////                file.WriteLine("Fourth line");
////////            }



        //public string createTxtFbos(Documento doc, String fileName)
        //{
        //    String file = String.Empty;
        //    file += "            XXX INICIO DOCUMENTO\n";
        //    file += "========== AREA IDENTIFICACION DEL DOCUMENTO\n";
        //    file += "Tipo Documento Tributario Electronico            : " + doc.TipoDTE + "\n";
        //    file += "Folio Documento                                  : " + "\n";
        //    file += "Fecha de Emision                                 : " + doc.FchEmis + "\n";
        //    file += "Indicador de No Rebaja                           : " + vacioSiCero(doc.IndNoRebaja.ToString()) + "\n";
        //    file += "Tipo de despacho                                 : " + vacioSiCero(doc.TipoDespacho.ToString()) + "\n";
        //    file += "Indicador de traslado                            : " + vacioSiCero(doc.IndTraslado.ToString()) + "\n";
        //    file += "Tipo Impresion                                   : " + "\n";
        //    file += "Indicador de servicio                            : " + vacioSiCero(doc.IndServicio.ToString()) + "\n";
        //    file += "Indicador de Montos Brutos                       : " + "\n";
        //    file += "Indicador de Montos Netos                        : " + "\n";
        //    if (doc.TipoDTE == 39 || doc.FmaPago == 0)
        //    {
        //        file += "Forma de Pago                                    : " + "\n";
        //    }
        //    else
        //    {
        //        file += "Forma de Pago                                    : " + doc.FmaPago + "\n";
        //    }

        //    file += "Forma de Pago Exportacion                        : " + "\n";
        //    file += "Fecha de Cancelacion                             : " + "\n";
        //    file += "Monto Cancelado                                  : " + "\n";
        //    file += "Saldo Insoluto                                   : " + "\n";
        //    file += "Fecha Monto y Glosa                              :                                                                     " + "\n";
        //    file += "Fecha Monto y Glosa                              :                                                                     " + "\n";
        //    file += "Fecha Monto y Glosa                              :                                                                     " + "\n";
        //    file += "Fecha Monto y Glosa                              :                                                                     " + "\n";
        //    file += "Periodo Desde                                    : " + "\n";
        //    file += "Periodo Hasta                                    : " + "\n";
        //    file += "Medio de Pago                                    : " + "\n";
        //    file += "Tipo de Cuenta de Pago                           : " + "\n";
        //    file += "Numero de Cuenta de Pago                         : " + "\n";
        //    file += "Banco de Pago                                    : " + "\n";
        //    file += "Codigo Terminos de Pago                          : " + "\n";
        //    file += "Glosa del Termino de Pago                        : " + "\n";
        //    file += "Dias del Termino de Pago                         : " + "\n";
        //    if (doc.TipoDTE == 52)
        //    {
        //        file += "Fecha de Vencimiento                             : " + "\n";
        //    }
        //    else
        //    {
        //        file += "Fecha de Vencimiento                             : " + doc.FchVenc + "\n";
        //    }

        //    file += "========== AREA EMISOR" + "\n";
        //    file += "Rut emisor                                       : " + doc.RUTEmisor + "\n";
        //    file += "Razon Social Emisor                              : " + doc.RznSoc + "\n";
        //    file += "Giro Emisor                                      : " + doc.GiroEmis + "\n";
        //    file += "Telefono                                         : " + doc.Telefono + "\n";
        //    file += "Correo Emisor                                    : " + doc.CorreoEmisor + "\n";
        //    file += "ACTECO                                           : 151110" + "\n";
        //    file += "Codigo Emisor Traslado Excepcional               : " + "\n";
        //    file += "Folio Autorizacion                               : " + "\n";
        //    file += "Fecha Autorizacion                               : " + "\n";
        //    file += "Direccion de origen emisor                       : " + doc.DirOrigen + "\n";
        //    file += "Comuna de Origen Emisor                          : " + doc.CmnaOrigen + "\n";
        //    file += "Ciudad de Origen Emisor                          : " + doc.CiudadOrigen + "\n";
        //    file += "Nombre Sucursal                                  : " + doc.Sucursal + "\n";
        //    file += "Codigo Sucursal                                  : " + "\n";
        //    file += "Codigo Adicional Sucursal                        : " + "\n";
        //    file += "Codigo Vendedor                                  : " + doc.CdgVendedor + "\n";
        //    file += "Identificador Adicional del Emisor               : " + "\n";
        //    file += "Rut Mandante                                     : " + doc.RUTMandante + "\n";
        //    file += "========== AREA RECEPTOR" + "\n";
        //    if (doc.TipoDTE == 39)
        //    {
        //        file += "Rut Receptor                                     : 66666666-6" + "\n";
        //    }
        //    else
        //    {
        //        file += "Rut Receptor                                     : " + doc.RUTRecep + "\n";
        //    }

        //    file += "Codigo interno Receptor                          : " + "\n";
        //    file += "Nombre o Razon Social Receptor                   : " + doc.RznSocRecep + "\n";
        //    file += "Numero Identificador Receptor Extranjero         : " + "\n";
        //    file += "Nacionalidad del Receptor Extranjero             : " + "\n";
        //    file += "Identificador Adicional Receptor Extranjero      : " + "\n";
        //    file += "Giro del negocio del receptor                    : " + doc.GiroRecep + "\n";
        //    file += "Contacto                                         : " + doc.Contacto + "\n";
        //    file += "Correo Receptor                                  : " + doc.CorreoRecep + "\n";
        //    file += "Direccion Receptor                               : " + doc.DirRecep + "\n";
        //    file += "Comuna Receptor                                  : " + doc.CmnaRecep + "\n";
        //    file += "Ciudad Receptor                                  : " + doc.CiudadRecep + "\n";
        //    file += "Direccion Postal Receptor                        : " + doc.DirPostal + "\n";
        //    file += "Comuna Postal Receptor                           : " + doc.CmnaPostal + "\n";
        //    file += "Ciudad Postal Receptor                           : " + doc.CiudadPostal + "\n";
        //    file += "Rut Solicitante de Factura                       : " + doc.RUTSolicita + "\n";
        //    file += "========== AREA TRANSPORTE" + "\n";
        //    file += "Patente                                          : " + doc.Patente + "\n";
        //    file += "Rut Transportista                                : " + doc.RUTCiaTransp + "\n";
        //    file += "Rut Chofer                                       : " + doc.RUTChofer + "\n";
        //    file += "Nombre Chofer                                    : " + doc.NombreChofer + "\n";
        //    file += "Direccion Destino                                : " + doc.DirDest + "\n";
        //    file += "Comuna Destino                                   : " + doc.CmnaDest + "\n";
        //    file += "Ciudad Destino                                   : " + "\n";
        //    file += "Modalidad De Ventas                              : " + "\n";
        //    file += "Clausula de Venta Exportacion                    : " + "\n";
        //    file += "Total Clausula de Venta Exportacion              : " + "\n";
        //    file += "Via de Transporte                                : " + "\n";
        //    file += "Nombre del Medio de Transporte                   : " + "\n";
        //    file += "RUT Compania de Transporte                       : " + doc.RUTCiaTransp + "\n";
        //    file += "Nombre Compania de Transporte                    : " + doc.NomCiaTransp + "\n";
        //    file += "Identificacion Adicional Compania de Transporte  : " + "\n";
        //    file += "Booking                                          : " + "\n";
        //    file += "Operador                                         : " + "\n";
        //    file += "Puerto de Embarque                               : " + "\n";
        //    file += "Identificador Adicional Puerto de Embarque       : " + "\n";
        //    file += "Puerto Desembarque                               : " + "\n";
        //    file += "Identificador Adicional Puerto de Desembarque    : " + "\n";
        //    file += "Tara                                             : " + vacioSiCero(doc.Tara.ToString()) + "\n";
        //    file += "Unidad de Medida Tara                            : " + vacioSiCero(doc.CodUnidMedTara.ToString()) + "\n";
        //    file += "Total Peso Bruto                                 : " + vacioSiCero(doc.PesoBruto.ToString()) + "\n";
        //    file += "Unidad de Peso Bruto                             : " + vacioSiCero(doc.CodUnidPesoBruto.ToString()) + "\n";
        //    file += "Total Peso Neto                                  : " + vacioSiCero(doc.PesoNeto.ToString()) + "\n";
        //    file += "Unidad de Peso Neto                              : " + vacioSiCero(doc.CodUnidPesoNeto.ToString()) + "\n";
        //    file += "Total Items                                      : " + vacioSiCero(doc.TotItems.ToString()) + "\n";
        //    file += "Total Bultos                                     : " + vacioSiCero(doc.TotBultos.ToString()) + "\n";
        //    file += "Informacion de Bultos                            :                                                                                                                                                                                                                                                                                                                                                                                                " + "\n";
        //    file += "Informacion de Bultos                            :                                                                                                                                                                                                                                                                                                                                                                                                " + "\n";
        //    file += "Informacion de Bultos                            :                                                                                                                                                                                                                                                                                                                                                                                                " + "\n";
        //    file += "Informacion de Bultos                            :                                                                                                                                                                                                                                                                                                                                                                                                " + "\n";
        //    file += "Flete                                            : " + "\n";
        //    file += "Seguro                                           : " + "\n";
        //    file += "Codigo Pais Receptor                             : " + "\n";
        //    file += "Codigo Pais Destino                              : " + "\n";
        //    file += "========== AREA TOTALES" + "\n";
        //    file += "Tipo Moneda Transaccion                          : " + doc.TpoMoneda + "\n";
        //    file += "Monto Neto                                       : " + doc.MntNeto + "\n";
        //    file += "Monto Exento                                     : " + vacioSiCero(doc.MntExe.ToString()) + "\n";
        //    file += "Monto Base Faenamiento de Carne                  : " + "\n";
        //    file += "Monto Base de Margen de  Comercializacion        : " + vacioSiCero(doc.MntMargenCom.ToString()) + "\n";
        //    file += "Tasa IVA                                         : " + doc.TasaIVA + "\n";
        //    file += "IVA                                              : " + doc.IVA + "\n";
        //    file += "Iva Propio                                       : " + vacioSiCero(doc.IVAProp.ToString()) + "\n";
        //    file += "Iva terceros                                     : " + vacioSiCero(doc.IVATerc.ToString()) + "\n";

        //    // 6 lineas de impuestos adicionales

        //    for (int i = 0; i < 6; i++)
        //    {
        //        file += "Codigo Impuesto Adicional y Monto                : " + "\n";
        //    }

        //    file += "IVA no Retenido                                  : " + vacioSiCero(doc.IVANoRet.ToString()) + "\n";
        //    file += "Credito Especial Emp. Constructoras              : " + "\n";
        //    file += "Garantia Deposito Envases                        : " + "\n";
        //    file += "Valor Neto Comisiones                            : " + "\n";
        //    file += "Valor Exento Comisiones                          : " + "\n";
        //    file += "IVA Comisiones                                   : " + "\n";
        //    file += "Monto Total                                      : " + doc.MntTotal + "\n";
        //    file += "Monto No Facturable                              : " + "\n";
        //    file += "Monto Periodo                                    : " + "\n";
        //    file += "Saldo Anterior                                   : " + "\n";
        //    file += "Valor a Pagar                                    : " + "\n";
        //    file += "========== OTRA MONEDA" + "\n";
        //    file += "Tipo Moneda                                      : " + "\n";
        //    file += "Tipo Cambio                                      : " + "\n";
        //    file += "Monto Neto Otra Moneda                           : " + "\n";
        //    file += "Monto Exento Otra Moneda                         : " + "\n";
        //    file += "Monto Base Faenamiento de Carne Otra Moneda      : " + "\n";
        //    file += "Monto Margen Comerc. Otra Moneda                 : " + "\n";
        //    file += "IVA Otra Moneda                                  : " + "\n";
        //    file += "Tipo Imp. Otra Moneda                            : " + "\n";
        //    file += "Tasa Imp. Otra Moneda                            : " + "\n";
        //    file += "Valor Imp. Otra Moneda                           : " + "\n";
        //    file += "IVA No Retenido Otra Moneda                      : " + "\n";
        //    file += "Monto Total Otra Moneda                          : " + "\n";
        //    file += "========== DETALLE DE PRODUCTOS Y SERVICIOS" + "\n";

        //    // 30 lineas de detalle

        //    foreach (var det in doc.detalle)
        //    {
        //        file += lineaDetalle(det) + "\n";
        //    }

        //    for (int i = 0; i < 30 - doc.detalle.Count(); i++)
        //    {
        //        file += "" + "\n";
        //    }

        //    file += "========== FIN DETALLE" + "\n";
        //    file += "========== SUB TOTALES INFORMATIVO" + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "                                                                                                                                        " + "\n";
        //    file += "========== DESCUENTOS Y RECARGOS" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "========== INFORMACION DE REFERENCIA" + "\n";

        //    // 40 lineas de referencia

        //    if (doc.TipoDTE != 39)
        //    {
        //        int countReferencia = 0;
        //        foreach (var referencia in doc.Referencia)
        //        {
        //            if (referencia.NroLinRef != 0)
        //            {
        //                file += lineaReferencia(referencia) + "\n";
        //                countReferencia++;
        //            }
        //        }

        //        Console.WriteLine("LINEAS DE REFERENCIA ******************" + doc.Referencia.Count());

        //        for (int i = 0; i < 40 - countReferencia; i++)
        //        {
        //            file += "                                                                                                                                           " + "\n";
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 0; i < 40; i++)
        //        {
        //            file += "                                                                                                                                           " + "\n";
        //        }
        //    }

        //    file += "========== COMISIONES Y OTROS CARGOS" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "" + "\n";
        //    file += "========== CAMPOS PERSONALIZADOS" + "\n";
        //    file += "Monto Palabras                                   : " + "\n";
        //    file += "Condicion Venta                                  : " + "\n";
        //    file += "OC o GD                                          : " + "\n";
        //    file += "Vendedor                                         : " + doc.NomVendedor + "\n";
        //    file += "CodigoSAP                                        : 1" + "\n";
        //    file += "Observaciones                                    : " + "\n";
        //    file += "Impresora                                        : 192.168.1.33" + "\n";
        //    file += "                                                 : " + "\n";
        //    file += "                                                 : " + "\n";
        //    file += "                                                 : " + "\n";
        //    file += "                                                 : " + "\n";
        //    file += "                                                 : " + "\n";
        //    file += "                                                 : " + "\n";
        //    file += "                                                 : " + "\n";
        //    file += "                                                 : " + "\n";
        //    file += "                                                 : " + "\n";
        //    file += "XXX FIN DOCUMENTO" + "\n";

        //    using (System.IO.StreamWriter fileDisc = new System.IO.StreamWriter(fileName, false, Encoding.GetEncoding("ISO-8859-1")))
        //    {
        //        fileDisc.WriteLine(file);
        //    }

        //    return file;
        //}


    }
} 
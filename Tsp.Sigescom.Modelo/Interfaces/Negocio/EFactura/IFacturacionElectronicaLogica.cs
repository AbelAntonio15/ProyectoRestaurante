﻿using OpenInvoicePeru.Comun.Dto.Intercambio;
using OpenInvoicePeru.Comun.Dto.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tsp.FacturacionElectronica.Modelo;
using Tsp.Sigescom.Modelo.ClasesNegocio.Core.Establecimientos;
using Tsp.Sigescom.Modelo.Entidades;
using Tsp.Sigescom.Modelo.Entidades.ComprobantesModel;
using Tsp.Sigescom.Modelo.Entidades.Custom;
using Tsp.Sigescom.Modelo.Entidades.EFactura;
using Tsp.Sigescom.Modelo.Entidades.Exceptions;
using Tsp.Sigescom.Modelo.Entidades.Sesion;

namespace Tsp.Sigescom.Modelo.Interfaces.Logica
{
    public interface IFacturacionElectronicaLogica
    {

        OperationResult ActualizarBinario(Binario binario);
        OperationResult ActualizarDocumentoAEnviado(long idDocumento);
        OperationResult ActualizarDocumentosAEnviados(long[] idDocumentos);
        OperationResult ActualizarEnvioDeDocumento(EnviarDocumentoResponse envioDocumentoResponse, long idEnvio);
        OperationResult ActualizarEnvios(List<Envio> enviosAActualizar);
        OperationResult ActualizarEstadoEnvio(Envio envioAActualizar);
        OperationResult ActualizarEstadoEnvioPendiente(Envio envioPendiente);
        OperationResult ActualizarEstadoEnvioRechazado(Envio envioRechazado);
        OperationResult ActualizarEstadosEnviosConExcepcion(List<Envio> envios);
        EnviarDocumentoResponse ConsultarConstanciaDocumento(DocumentoElectronico documento);
        EnviarDocumentoResponse ConsultarConstanciaTicket(string ruc, EnvioSimplificado envioAConsultar);
        OperationResult ConsultarTicket(string ruc, EnvioSimplificado envioAConsultar);
        OperationResult ConsultarTickets();
        OperationResult CrearBinario(byte[] archivo);
        OperationResult CrearDocumentosMasivos(List<Documento> documentosAIngresar);
        OperationResult CrearEnvio(string identificadorEnvio, string tipoEnvio, int estado, string codigoRespuesta, string observacion, string numeroTicket, byte[] envio, byte[] respuesta, ModoEnvio modoEnvio);
        OperationResult CrearEnvioDocumento(long idEnvio, long idDocumento);
        OperationResult CrearEnvioDocumentoMasivo(long idEnvio, long[] idDocumentos);
        int DeterminarEstadoDeEnvio(EnviarDocumentoResponse enviarDocumentoResponse);
        List<Documento> DevolverBoletasIncluidoBinarioPorEnviarPorDia();
        List<Documento> DevolverFacturasInvalidadasNoEnviadasPorDia();
        List<Documento> DevolverFacturasNoInvalidadasIncluidoBinarioPorEnviar();
        List<Documento> DevolverGuiasDeRemisionIncluidoBinarioPorEnviar();
        List<Documento> DevolverNotasCreditoIncluidoBinarioPorEnviar();
        List<Documento> DevolverNotasDebitoIncluidoBinarioPorEnviar();
        string DevolverUrlEnvioSunatFacturacionElectronica();
        string DevolverUrlEnvioSunatGuiaDeRemisionElectronica();
        OperationResult EnviarComunicacionBaja(EstablecimientoComercial sede, ComunicacionBaja comunicacionBaja, FirmadoResponse firmadoResponse, long[] idDocumentos);
        EnviarDocumentoResponse EnviarDocumento(FirmadoResponse firmadoResponse, DocumentoElectronico documentoElectronico);
        OperationResult EnviarResumenDiario(ResumenDiarioNuevo resumenDiarioNuevo, FirmadoResponse firmadoResponse, long[] idDocumentos, ModoEnvio modoEnvio);
        OperationResult EnvioBoletas(LogEnvio logEnvio);
        OperationResult EnvioComunicacionesBaja(LogEnvio logEnvio);
        OperationResult EnvioFacturas(LogEnvio logEnvio);
        Task<OperationResult> EnviarGuiaDeRemisionManual(DateTime fechaDesde, DateTime fechaHasta, EstablecimientoComercialExtendido sede, int idEmpleado, string path);
        OperationResult ConsultarGuiasRemisionManual();
        Task<OperationResult> TransmitirEnviarGuiaDeRemision(long idMovimiento, EstablecimientoComercialExtendido sede, int idEmpleado, string path);
        OperationResult EnvioNotasCredito(LogEnvio logEnvio);
        OperationResult EnvioNotasDebito(LogEnvio logEnvio);
        FirmadoResponse FirmarDocumento(DocumentoResponse documentoResponse, byte[] archivoCertificado);
        Envio GenerarEnvioAActualizar(EnviarDocumentoResponse envioDocumentoResponse, long idEnvio);
        bool HayBoletasNoEnviadas();
        bool HayFacturasInvalidadasNoEnviadas();
        List<Envio> ObteneEnviosConExcepcionAReenviar();
        List<Envio> ObteneEnviosPendientesAReenviar();
        byte[] ObtenerArchivo(long id);
        List<Documento> ObtenerBoletasInvalidadasEnviadasAceptadasUnaSolaVezSinEnvioPendiente();
        byte[] ObtenerCertificado(string nombreCertificado);
        Documento ObtenerDocumentoElectronicoIncluidoBinario(long id);
        List<Documento> ObtenerDocumentos(List<long> idDocumentos);
        List<Documento> ObtenerDocumentosEntreFechas(DateTime fechaDesde, DateTime fechaHasta);
        ActorComercial ObtenerEmisor(int idEmisor);
        Envio ObtenerEnvio(long idEnvio);
        List<Envio> ObtenerEnviosEntreFechas(DateTime fechaDesde, DateTime fechaHasta);
        List<EnvioSimplificado> ObtenerEnviosSinCodigoDeRespuesta();
        List<Documento> ObtenerFacturasInvalidadasAceptadasPeroSinComunicacionDeBaja();
        List<Documento> ObtenerFacturasInvalidadasEnviadasAceptadasUnaSolaVezSinEnvioPendiente();
        string ObtenerMetodoApi(string codigoTipoDocumento);
        List<Documento> ObtenerNotasCreditoInvalidadasAceptadasPeroSinComunicacionDeBaja();
        List<Documento> ObtenerNotasCreditoInvalidadasEnviadasAceptadasUnaSolaVezSinEnvioPendiente();
        List<Documento> ObtenerNotasDebitoInvalidadasAceptadasPeroSinComunicacionDeBaja();
        List<Documento> ObtenerNotasDebitoInvalidadasEnviadasAceptadasUnaSolaVezSinEnvioPendiente();
        string ObtenerQR(MovimientoDeAlmacen movimiento, EstablecimientoComercial Sede);
        string ObtenerQR(OrdenDeVenta orden, EstablecimientoComercial Sede);
        byte[] RegenerarJsonBoleta(long idOrden, EstablecimientoComercialExtendido sede);
        Task<OperationResult> RegenerarJsonDocumento(long idDocumento);
        byte[] RegenerarJsonFactura(long idOrden, EstablecimientoComercialExtendido sede);
        Task<byte[]> RegenerarJsonGuiaDeRemision(long idMovimiento, EstablecimientoComercialExtendido sede);
        Task<byte[]> RegenerarJsonNotasDeCredito(long idOrden, EstablecimientoComercialExtendido sede);
        Task<byte[]> RegenerarJsonNotasDeDebito(long idOrden, EstablecimientoComercialExtendido sede);
        OperationResult ResolverComunicacionBaja(EstablecimientoComercialExtendido sede, Documento[] documentos, LogEnvio logEnvio);
        OperationResult ResolverComunicacionBaja(EstablecimientoComercialExtendido sede, Envio envio);
        OperationResult ResolverComunicacionBajaConExcepcion(EstablecimientoComercialExtendido sede, List<Envio> enviosConExcepcion, LogEnvio logEnvio);
        EnviarDocumentoResponse ResolverConsultaDocumento(DocumentoElectronico documentoElectronico, long idEnvio);
        EnviarDocumentoResponse ResolverConsultaTicket(string ruc, EnvioSimplificado envioAConsultar);
        EnviarDocumentoResponse ResolverEnvioDocumento(FirmadoResponse firmadoResponse, DocumentoElectronico documentoElectronico, long idEnvio, IndicadorExcepcion logDeEnvio);
        OperationResult ResolverEnvioFactura(Envio envio);
        OperationResult ResolverEnvioFacturasConExcepcion(List<Envio> enviosConExcepcion, LogEnvio logEnvio);
        OperationResult ResolverEnvioIndividual(Documento[] documentos, LogEnvio logEnvio);
        OperationResult ResolverEnvioNota(Envio envio);
        OperationResult ResolverEnvioNotas(Documento[] documentos, LogEnvio logEnvio);
        OperationResult ResolverEnvioNotasCreditoConExcepcion(List<Envio> notasCreditoConExcepcion, List<Envio> notasDebitoConExcepcion, LogEnvio logEnvio);
        OperationResult ResolverEnvioNotasDebitoConExcepcion(List<Envio> notasCreditoConExcepcion, List<Envio> notasDebitoConExcepcion, LogEnvio logEnvio);
        OperationResult ResolverEnvioPendiente(int idEnvio);
        OperationResult ResolverEnvioRechazado(int idEnvio);
        Task<OperationResult> ResolverEnviosConExcepcion();
        OperationResult ResolverEnviosPendientes();
        OperationResult ResolverResumenDiario(EstablecimientoComercialExtendido sede, Documento[] documentos, bool cambiarEstadoItemDeAnuladoAAdicionado, string mensajeErrorEnvio, string mensajeErrorConsultaTicket, ModoEnvio modoEnvio);
        OperationResult ResolverResumenDiario(EstablecimientoComercialExtendido sede, Envio envio);
        OperationResult ResolverResumenDiarioConExcepcion(EstablecimientoComercialExtendido sede, List<Envio> enviosConExcepcion, LogEnvio logEnvio);
        OperationResult ResolverResumenDiarioInvalidados(EstablecimientoComercialExtendido sede, Documento[] documentosInvalidados);
        OperationResult ResolverResumenDiarioPorDia(EstablecimientoComercialExtendido sede, Documento[] documentos, LogEnvio logEnvio);
        Task<OperationResult> TransmitirAFacturacionElectronica(int idEmpleado, EstablecimientoComercialExtendido sede);
        OperationResult TransmitirBoletasAFacturacionElectronica(List<Detalle_maestro> detallesMaestroComprobante, int idEmpleado, EstablecimientoComercialExtendido sede, DateTime fechaActual);
        OperationResult TransmitirFacturasAFacturacionElectronica(List<Factura> facturas, List<Detalle_maestro> detallesMaestroComprobante, int idEmpleado, DateTime fechaActual);
        OperationResult TransmitirGuiaDeRemisionAFacturacionElectronica(List<GuiaDeRemision> guiasDeRemision, List<Detalle_maestro> detallesMaestroComprobante, int idEmpleado, DateTime fechaActual);
        OperationResult TransmitirNotasDeCreditoAFacturacionElectronica(List<NotaDeCredito> notasDeCredito, List<Detalle_maestro> detallesMaestroComprobante, int idEmpleado, DateTime fechaActual);
        OperationResult TransmitirNotasDeDebitoAFacturacionElectronica(List<NotaDeDebito> notasDeDebito, List<Detalle_maestro> detallesMaestroComprobante, int idEmpleado, DateTime fechaActual);
    }
}
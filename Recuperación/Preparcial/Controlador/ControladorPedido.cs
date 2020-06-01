﻿using System;
using System.Data;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorPedido
    {
        public static DataTable GetPedidosUsuarioTable(string id)
        {
            DataTable pedidos = null;

            try
            {   //cambio de nombreArticulo a nombreArt y arreglar consultas de GetPedidosUsuarioTable
                pedidos = ConexionBD.EjecutarConsulta("SELECT p.idPedido, i.nombreArt, p.cantidad, i.precio" +
                                            " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                                            " WHERE p.idArticulo = i.idArticulo" +
                                            " AND p.idUsuario = u.idUsuario" +
                                            $" AND u.idUsuario = {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }

        public static DataTable GetPedidosTable()
        {
            DataTable pedidos = null;

            try
            {   //cambio de nombreArticulo a nombreArt y arreglar consultas de GetPedidosTable
                pedidos = ConexionBD.EjecutarConsulta("SELECT p.idPedido, i.nombreArt, p.cantidad, i.precio" +
                                            " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                                            " WHERE p.idArticulo = i.idArticulo" +
                                            " AND p.idUsuario = u.idUsuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }

        public static void HacerPedido(string idUsuario, string idArticulo, string cantidad)
        {
            try
            {
                ConexionBD.EjecutarComando("INSERT INTO PEDIDO(idUsuario, idArticulo, cantidad) " +
                    $"VALUES({idUsuario}, {idArticulo}, {cantidad})");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}

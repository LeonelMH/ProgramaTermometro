using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace TermometroRemoto
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort;

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
        }

        private void InitializeSerialPort()
        {
            _serialPort = new SerialPort();
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataBits = 8;
            _serialPort.Handshake = Handshake.None;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            // Opcional: Lista de puertos disponibles
            foreach (string port in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(port);
            }

            if (comboBoxPorts.Items.Count > 0)
                comboBoxPorts.SelectedIndex = 0;
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                _serialPort.Open();
                labelEstado.Text = "Estado: Conectado";
                buttonConectar.Enabled = false;
                buttonDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el puerto serial: " + ex.Message);
            }
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Close();
                labelEstado.Text = "Estado: Desconectado";
                buttonConectar.Enabled = true;
                buttonDesconectar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar el puerto serial: " + ex.Message);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = _serialPort.ReadLine().Trim();
                this.BeginInvoke(new Action(() =>
                {
                    labelTemperatura.Text = data + " °C";
                }));
            }
            catch (Exception)
            {
                // Manejo de errores opcional
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serialPort.IsOpen)
                _serialPort.Close();
        }
    }
}
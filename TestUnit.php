<?php

class TestUnit extends CI_Controller{
    public function __construct()
    {
        parent::__construct();
        $this->load->library('unit_test'); 
    }

    private function ascen($table)
    {
        $this->db->order_by('nama_donasi', 'ASC');
        $query = $this->db->get($table);
        return $query;
    }

    private function descen($table)
    {
        $this->db->order_by('nama_donasi', 'DESC');
        $query = $this->db->get($table);

        return $query;
    }

    public function testdescen($table)
    {
        $test = $this-> ascen ('DESC');
        $expected_result = TRUE;
        $test_name = 'Sorting sesuai A - Z';
        echo $this->unit->run($test,$expected_result,$test_name);
    }

    public function testascen($table)
    {
        $test = $this-> ascen ('ASC');
        $expected_result = TRUE;
        $test_name = 'Sorting sesuai A - Z';
        echo $this->unit->run($test,$expected_result,$test_name);
    }
}
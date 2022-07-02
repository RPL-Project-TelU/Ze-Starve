<?php

class UnitTest extends CI_Controller
{
    public function __construct(){

        parent::__construct();
        $this->load->library('Unit_test');
    }
    private function auth ($sername,$pass)
    {
        $auth =$cek_admin = $this->MdlLogin->authAdmin($username, $pass);
    }
    function TestLogin ()
    {
        $test = $this ->auth ('admin','admin');
        $expected_result = true
        $test_name = 'Login Test'
        echo $this -> unit -> run($test,$expected_result,$test_name);
    }

}
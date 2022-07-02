<?php

class FeedbackTest extends \PHPUnit\Framework\TestCase {
    public function testDelete() {

        $Feedback = new App\Controllers\Feedback;
        $result = $Feedback->delete('2');

        $this->assertEquals('3', $result);
    }
}
<?php

use yii\helpers\Html;
use yii\grid\GridView;

/* @var $this yii\web\View */
/* @var $dataProvider yii\data\ActiveDataProvider */

$this->title = 'Samolots';
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="samolot-index">

    <h1><?= Html::encode($this->title) ?></h1>

    <p>
        <?= Html::a('Create Samolot', ['create'], ['class' => 'btn btn-success']) ?>
    </p>

    <?= GridView::widget([
        'dataProvider' => $dataProvider,
        'columns' => [
            ['class' => 'yii\grid\SerialColumn'],

            'id',
            'model',
            'rok_produkcji',
            'liczba_miejsc',

            ['class' => 'yii\grid\ActionColumn'],
        ],
    ]); ?>

</div>

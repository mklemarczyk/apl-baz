<?php

use yii\helpers\Html;
use yii\grid\GridView;

/* @var $this yii\web\View */
/* @var $searchModel frontend\models\LotSearch */
/* @var $dataProvider yii\data\ActiveDataProvider */

$this->title = 'Loty';
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="lot-index">

    <h1><?= Html::encode($this->title) ?></h1>
    <?php // echo $this->render('_search', ['model' => $searchModel]); ?>

    <p>
        <?= Html::a('Stwórz Lot', ['create'], ['class' => 'btn btn-success']) ?>
    </p>

    <?= GridView::widget([
        'dataProvider' => $dataProvider,
        'filterModel' => $searchModel,
        'columns' => [
            ['class' => 'yii\grid\SerialColumn'],

            // 'id',
            'numer_lotu',
            'data_wylotu',
            'czas_lotu',
            'samolot.nazwa',
            'lotniskoStart.nazwa',
            'lotniskoEnd.nazwa',

            ['class' => 'yii\grid\ActionColumn'],
        ],
    ]); ?>

</div>

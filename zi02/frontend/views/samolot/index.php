<?php

use yii\helpers\Html;
use yii\grid\GridView;

/* @var $this yii\web\View */
/* @var $searchModel frontend\models\SamolotSearch */
/* @var $dataProvider yii\data\ActiveDataProvider */

$this->title = 'Samoloty';
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="samolot-index">

    <h1><?= Html::encode($this->title) ?></h1>
    <?php // echo $this->render('_search', ['model' => $searchModel]); ?>

    <p>
        <?= Html::a('Stwórz samolot', ['create'], ['class' => 'btn btn-success']) ?>
    </p>

    <?= GridView::widget([
        'dataProvider' => $dataProvider,
        'filterModel' => $searchModel,
        'columns' => [
            ['class' => 'yii\grid\SerialColumn'],

            // 'id',
            'model',
            'rok_produkcji:date',
            'liczba_miejsc:integer',

            ['class' => 'yii\grid\ActionColumn'],
        ],
    ]); ?>

</div>

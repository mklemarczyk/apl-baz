<?php

use yii\helpers\Html;
use yii\grid\GridView;

/* @var $this yii\web\View */
/* @var $searchModel frontend\models\BiletSearch */
/* @var $dataProvider yii\data\ActiveDataProvider */

$this->title = 'Bilety';
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="bilet-index">

    <h1><?= Html::encode($this->title) ?></h1>
    <?php // echo $this->render('_search', ['model' => $searchModel]); ?>

    <p>
        <?= Html::a('Stwórz bilet', ['create'], ['class' => 'btn btn-success']) ?>
    </p>

    <?= GridView::widget([
        'dataProvider' => $dataProvider,
        'filterModel' => $searchModel,
        'columns' => [
            ['class' => 'yii\grid\SerialColumn'],

            // 'id',
            'klasa',
            'numer_miejsca',
            'cena',
            'imie',
            'nazwisko',
            'lot.nazwa',
            'zakup.nazwa',

            ['class' => 'yii\grid\ActionColumn'],
        ],
    ]); ?>

</div>

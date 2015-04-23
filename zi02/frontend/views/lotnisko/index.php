<?php

use yii\helpers\Html;
use yii\grid\GridView;

/* @var $this yii\web\View */
/* @var $searchModel frontend\models\LotniskoSearch */
/* @var $dataProvider yii\data\ActiveDataProvider */

$this->title = 'Lotniskos';
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="lotnisko-index">

    <h1><?= Html::encode($this->title) ?></h1>
    <?php // echo $this->render('_search', ['model' => $searchModel]); ?>

    <p>
        <?= Html::a('Create Lotnisko', ['create'], ['class' => 'btn btn-success']) ?>
    </p>

    <?= GridView::widget([
        'dataProvider' => $dataProvider,
        'filterModel' => $searchModel,
        'columns' => [
            ['class' => 'yii\grid\SerialColumn'],

            // 'id',
            'nazwa',
            'miasto',
            'kraj',

            ['class' => 'yii\grid\ActionColumn'],
        ],
    ]); ?>

</div>

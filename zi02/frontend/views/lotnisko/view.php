<?php

use yii\helpers\Html;
use yii\widgets\DetailView;

/* @var $this yii\web\View */
/* @var $model common\models\Lotnisko */

$this->title = $model->nazwa;
$this->params['breadcrumbs'][] = ['label' => 'Lotniska', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="lotnisko-view">

    <h1><?= Html::encode($this->title) ?></h1>

    <p>
        <?= Html::a('Zmień', ['update', 'id' => $model->id], ['class' => 'btn btn-primary']) ?>
        <?= Html::a('Usuń', ['delete', 'id' => $model->id], [
            'class' => 'btn btn-danger',
            'data' => [
                'confirm' => 'Czy na pewno chcesz usunąć ten element?',
                'method' => 'post',
            ],
        ]) ?>
    </p>

    <?= DetailView::widget([
        'model' => $model,
        'attributes' => [
            // 'id',
            'nazwa',
            'miasto',
            'kraj',
        ],
    ]) ?>

</div>
